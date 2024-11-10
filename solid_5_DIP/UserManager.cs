using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_5_DIP
{
    internal class UserManager
    {
        private readonly ILogger _logger;

        public UserManager(ILogger logger)
        {
            _logger = logger;
        }

        public void CreateUser(string username)
        {
            _logger.Log($"Пользователь {username} создан.");
        }
    }
}
