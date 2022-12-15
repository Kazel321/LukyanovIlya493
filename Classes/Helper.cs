using PerfumeWorld.Classes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeWorld.Classes
{
    public static class Helper
    {
        public static DB DB;
        public static Roles Role;
        public static int UserId;
        public static string UserFullName;
        public static FormEvents FormEvent;
    }

    public enum Roles { Гость, Администратор, Менеджер, Клиент}
    public enum FormEvents { Добавление, Редактирование}
}
