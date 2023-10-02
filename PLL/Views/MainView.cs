using Module_19.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module_19.PLL.Views
{
    public class MainView
    {
        public void Show()
        {
            Console.WriteLine("Войти в профиль (нажмите 1)");
            Console.WriteLine("Зарегистрироваться (нажмите 2)");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Program.authenticationView.Show();
                        break;
                    }

                case "2":
                    {
                        Program.registrationView.Show();
                        break;
                    }
            }
        }
    }
}
