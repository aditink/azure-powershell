﻿using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using NET_API_STATUS = System.UInt32;


namespace Microsoft.Azure.Commands.StorageSync.Evaluation
{
    public static class WinErrors
    {
        #region definitions
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr LocalFree(IntPtr hMem);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int FormatMessage(FormatMessageFlags dwFlags, IntPtr lpSource, uint dwMessageId, uint dwLanguageId, ref IntPtr lpBuffer, uint nSize, IntPtr Arguments);

        [Flags]
        private enum FormatMessageFlags : uint
        {
            FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x00000100,
            FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200,
            FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000,
            FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x00002000,
            FORMAT_MESSAGE_FROM_HMODULE = 0x00000800,
            FORMAT_MESSAGE_FROM_STRING = 0x00000400,
        }
        #endregion

        public static string GetSystemMessage(int errorCode)
        {
            try
            {
                IntPtr lpMsgBuf = IntPtr.Zero;

                int dwChars = FormatMessage(
                    FormatMessageFlags.FORMAT_MESSAGE_ALLOCATE_BUFFER | FormatMessageFlags.FORMAT_MESSAGE_FROM_SYSTEM | FormatMessageFlags.FORMAT_MESSAGE_IGNORE_INSERTS,
                    IntPtr.Zero,
                    (uint)errorCode,
                    0, // Default language
                    ref lpMsgBuf,
                    0,
                    IntPtr.Zero);
                if (dwChars == 0)
                {
                    int le = Marshal.GetLastWin32Error();
                    return "Unable to get error code string from System - Error " + le.ToString();
                }

                string sRet = Marshal.PtrToStringAnsi(lpMsgBuf);

                lpMsgBuf = LocalFree(lpMsgBuf);
                return sRet;
            }
            catch (Exception e)
            {
                return "Unable to get error code string from System -> " + e.ToString();
            }
        }
    }

    public class UNCNetworkConnector : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct USE_INFO_2
        {
            internal string ui2_local;
            internal string ui2_remote;
            internal string ui2_password;
            internal UInt32 ui2_status;
            internal UInt32 ui2_asg_type;
            internal UInt32 ui2_refcount;
            internal UInt32 ui2_usecount;
            internal string ui2_username;
            internal string ui2_domainname;
        }

        [DllImport("NetApi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern NET_API_STATUS NetUseAdd(
            string UncServerName,
            UInt32 Level,
            ref USE_INFO_2 Buf,
            out UInt32 ParmError);

        [DllImport("NetApi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern NET_API_STATUS NetUseDel(
            string UncServerName,
            string UseName,
            UInt32 ForceCond);

        private bool disposed = false;
        private string UNCPath;
        public int LastError { get; set; }

        public void Dispose()
        {
            if (!this.disposed)
            {
                NetUseDelete();
            }
            disposed = true;
            GC.SuppressFinalize(this);
        }

        /*
         * UNCPath: Fully qualified domain name UNC path
         * Domain: Domain of User
         * 
         * Return: True on success. LastError will hold the system error code in case of failure.
         **/
        public bool NetUseWithCredentials(string userUNCPath, string User, string Domain, string Password)
        {
            UNCPath = userUNCPath;

            uint returncode;
            try
            {
                USE_INFO_2 useinfo = new USE_INFO_2();

                useinfo.ui2_local = null;
                useinfo.ui2_remote = UNCPath;
                useinfo.ui2_username = User;
                useinfo.ui2_domainname = Domain;
                useinfo.ui2_password = Password;
                // useinfo.ui2_asg_type = 0;
                useinfo.ui2_usecount = 1;
                uint paramErrorIndex;
                returncode = NetUseAdd(null, 2, ref useinfo, out paramErrorIndex);

                if (returncode != 0)
                {
                    LastError = (int)returncode;
                }

                return returncode == 0;
            }
            catch
            {
                LastError = Marshal.GetLastWin32Error();

                return false;
            }
        }

        public string GetLastError()
        {
            return WinErrors.GetSystemMessage(LastError);
        }

         // Return: True on success. LastError will hold the system error code in case of failure.
        public bool NetUseDelete()
        {
            uint returncode;
            try
            {
                returncode = NetUseDel(null, UNCPath, 2);
                return (returncode == 0);
            }
            catch
            {
                LastError = Marshal.GetLastWin32Error();
                return false;
            }
        }

        ~UNCNetworkConnector()
        {
            Dispose();
        }

    }
}
 
 
 