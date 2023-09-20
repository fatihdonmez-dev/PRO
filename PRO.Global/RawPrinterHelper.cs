﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data;

namespace PRO.Global
{
    public class RawPrinterHelper
    {
        //// Structure and API declarions:
        //[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        //public class DOCINFOA
        //{
        //    [MarshalAs(UnmanagedType.LPStr)]
        //    public string pDocName;
        //    [MarshalAs(UnmanagedType.LPStr)]
        //    public string pOutputFile;
        //    [MarshalAs(UnmanagedType.LPStr)]
        //    public string pDataType;
        //}
        //[DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        //public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        //[DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        //public static extern bool ClosePrinter(IntPtr hPrinter);

        //[DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        //public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        //[DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        //public static extern bool EndDocPrinter(IntPtr hPrinter);

        //[DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        //public static extern bool StartPagePrinter(IntPtr hPrinter);

        //[DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        //public static extern bool EndPagePrinter(IntPtr hPrinter);

        //[DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        //public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        //[DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        //public static extern bool WritePrinter(IntPtr hPrinter, string pBytes, int dwCount, out int dwWritten);

        ///*=================================================*/

        //private IntPtr HandlePrinter;
        //private PrinterSettings ps;

        //public RawPrinterHelper()
        //{
        //    HandlePrinter = IntPtr.Zero;
        //    ps = new PrinterSettings();

        //}

        //public string PrinterName
        //{
        //    get
        //    {
        //        return ps.PrinterName;
        //    }
        //    set
        //    {
        //        ps.PrinterName = value;
        //    }
        //}

        //public bool ChoosePrinter()
        //{
        //    PrintDialog pd = new PrintDialog();
        //    pd.PrinterSettings = ps;
        //    if (pd.ShowDialog() == DialogResult.OK)
        //    {
        //        ps = pd.PrinterSettings;
        //        return true;
        //    }
        //    else return false;
        //}

        //public bool ChoosePrinterDefault()
        //{
        //    PrinterSettings settings = new PrinterSettings();
        //    settings.PrinterName = PrinterName;
        //    ps = settings;
        //    return true;

        //}




        //public bool Open(string DocName)
        //{
        //    // see if printer is already open
        //    if (HandlePrinter != IntPtr.Zero) return false;

        //    // opens the printer
        //    bool risp = OpenPrinter(ps.PrinterName, out HandlePrinter, IntPtr.Zero);
        //    if (risp == false) return false;

        //    // starts a print job
        //    DOCINFOA MyDocInfo = new DOCINFOA();
        //    MyDocInfo.pDocName = DocName;
        //    MyDocInfo.pOutputFile = null;
        //    MyDocInfo.pDataType = "RAW";


        //    if (StartDocPrinter(HandlePrinter, 1, MyDocInfo))
        //    {
        //        StartPagePrinter(HandlePrinter); //starts a page       
        //        return true;
        //    }
        //    else return false;
        //}

        //public bool Close()
        //{
        //    if (HandlePrinter == IntPtr.Zero) return false;
        //    if (!EndPagePrinter(HandlePrinter)) return false;
        //    if (!EndDocPrinter(HandlePrinter)) return false;
        //    if (!ClosePrinter(HandlePrinter)) return false;
        //    HandlePrinter = IntPtr.Zero;
        //    return true;
        //}

        //public bool Print(string outputstring)
        //{
        //    if (HandlePrinter == IntPtr.Zero) return false;

        //    //IntPtr buf = Marshal.StringToCoTaskMemAnsi(outputstring);

        //    IntPtr buf;

        //    string _wr = string.Format("Tip = {0}", Globals.Variables._GRawMethod);
        //    DataTable dtRaw = _Tables.TAN_RawPrintMethod.GetDataList(_wr);

        //    if (dtRaw.Rows.Count == 0 || Globals.Variables._GRawMethod == 1)
        //        buf = Marshal.StringToCoTaskMemAnsi(outputstring);
        //    else
        //        buf = NativeUtf8FromString(outputstring, dtRaw.Rows[0]["Name"].ToString());

        //    int dd = 0;

        //    string condensed = Convert.ToChar(15).ToString();
        //    WritePrinter(HandlePrinter, condensed, condensed.Length, out dd);

        //    Int32 done = 0;
        //    bool ok = WritePrinter(HandlePrinter, buf, outputstring.Length, out done);

        //    Marshal.FreeCoTaskMem(buf);

        //    if (!ok) return false;
        //    else return true;
        //}

        //public IntPtr NativeUtf8FromString(string managedString, string _mthdName)
        //{
        //    Encoding tr = Encoding.GetEncoding(_mthdName);
        //    //Encoding tr = Encoding.Default;
        //    int len = tr.GetByteCount(managedString);
        //    byte[] buffer = new byte[len + 1];
        //    tr.GetBytes(managedString, 0, managedString.Length, buffer, 0);
        //    IntPtr nativeUtf8 = Marshal.AllocHGlobal(buffer.Length);
        //    Marshal.Copy(buffer, 0, nativeUtf8, buffer.Length);
        //    return nativeUtf8;
        //}

    }
}
