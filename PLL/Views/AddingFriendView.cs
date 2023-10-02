using Module_19.BLL.Exceptions;
using Module_19.BLL.Models;
using Module_19.BLL.Services;
using Module_19.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module_19.PLL.Views
{
    public class AddingFriendView
    {
        UserService userService;
        public AddingFriendView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
            try
            {
                var userAddingFriendData = new UserAddingFriendData();

                Console.WriteLine("Введите почтовый адрес пользователя которого хотите добавить в друзья: ");

                userAddingFriendData.FriendEmail = Console.ReadLine();
                userAddingFriendData.UserId = user.Id;

                this.userService.AddFriend(userAddingFriendData);

                SuccessMessage.Show("Вы успешно добавили пользователя в друзья!");
            }

            catch(UserNotFoundException)
            {
                AlertMessage.Show("Пользователя с указанным почтовым адресом не существует!");
            }
            
            catch(Exception)
            {
                AlertMessage.Show("Произоша ошибка при добавлении пользотваеля в друзья!");
            }
 
        }
    }
}
