﻿using Module_19.BLL.Exceptions;
using Module_19.BLL.Models;
using Module_19.BLL.Services;
using Module_19.PLL;
using Module_19.PLL.Views;
using System;
using System.Linq;

namespace Module_19
{
    class Program
    {
        static MessageService messageService;
        static UserService userService;
        public static MainView mainView;
        public static RegistrationView registrationView;
        public static AuthenticationView authenticationView;
        public static UserMenuView userMenuView;
        public static UserInfoView userInfoView;
        public static UserDataUpdateView userDataUpdateView;
        public static MessageSendingView messageSendingView;
        public static UserIncomingMessageView userIncomingMessageView;
        public static UserOutcomingMessageView userOutcomingMessageView;
        public static AddingFriendView addingFriendView;
        public static UserFriendView userFriendView;

        static void Main(string[] args)
        {
            userService = new UserService();
            messageService = new MessageService();

            mainView = new MainView();
            registrationView = new RegistrationView(userService);
            authenticationView = new AuthenticationView(userService);
            userMenuView = new UserMenuView(userService);
            userInfoView = new UserInfoView();
            userDataUpdateView = new UserDataUpdateView(userService);
            messageSendingView = new MessageSendingView(messageService, userService);
            userIncomingMessageView = new UserIncomingMessageView();
            userOutcomingMessageView = new UserOutcomingMessageView();
            addingFriendView = new AddingFriendView(userService);
            userFriendView = new UserFriendView();

            while (true)
            {
                mainView.Show();
            }
        }
    }
}
