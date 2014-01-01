#define TEST1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//1
//4
//5
namespace Northwind {
  static class Program {
    /// <summary>
    /// アプリケーションのメイン エントリ ポイントです。
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
#if TEST
      Application.Run(new OrdersForm());
#else
      Application.Run(new OrdersFormCode());
#endif
    }
  }
}
