using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace GraphicModes
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txbResult_ASM_Foo_1.Text = "Waiting to press 'Start'";
        }

        void OnClickStart(object sender, RoutedEventArgs e)
        {

            IntPtr pMyClass = SomeAssemblerFunctions.Create();

            //if (IntPtr.Size == 8)
            // 64Bit
            //else
            // 32bit

            Int32 a = 0;
            Int64 b = 0;
            long c = 0;
            long rslt = 0;

            try
            {
                SomeAssemblerFunctions.SetGraphicMode1(pMyClass);

                if (Environment.Is64BitOperatingSystem)
                {
                    //"SysWOW64"
                    b = SomeAssemblerFunctions.GetEAX(pMyClass);
                    txbResult_ASM_Foo_1.Text = (b == 1) ? (1).ToString() : (0).ToString();
                }
                else
                {
                    //"system32"
                    a = SomeAssemblerFunctions.GetEAX(pMyClass);
                    txbResult_ASM_Foo_1.Text = (a == 1) ? (0).ToString() : (0).ToString();
                }

                txbResult_ASM_Foo_1.Text = (rslt == 1) ? (1).ToString() : (0).ToString();
            }
            catch (Exception)
            {
                // MessageBox.Show(ex.Message);
                //  MessageBox.Show(ex.GetType().ToString());
                txbResult_ASM_Foo_1.Text = "Error";
            }
        }
    }

    public class SomeAssemblerFunctions
    {
        [DllImport("SomeAssemblerFunctions.dll")]
        static public extern IntPtr Create();
        [DllImport("SomeAssemblerFunctions.dll")]
        static public extern void Dispose(IntPtr pMyClass);
        [DllImport("Microinvest.Graphics.dll"
            , EntryPoint = "SetGraphicMode1")]
        static public extern void SetGraphicMode1(IntPtr pMyClass);
        [DllImport("Microinvest.Graphics.dll"
            , EntryPoint = "GetEAX")]
        static public extern int GetEAX(IntPtr pGraphicsObject);
    }
}
