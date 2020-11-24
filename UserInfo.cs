namespace SqlSeverFrame
{
    public class UserInfo
    {
        //用户名
        private string username;
        //获取用户名
        public string getUserName()
        {
            return username;
        }
        //设置用户名
        public void setUserName( string username)
        {
            this.username = username;
        }


        //密码
        private string Password;
        //获取密码
        public string getPassword()
        {
            return username;
        }
        //设置密码
        public void setPassword(string Password)
        {
            this.Password = Password;
        }
        //登录状态
        private string UserState;

        public string getUserState()
        {
            return UserState;
        }

        public void setUserState(string UserState)
        {

            this.UserState = UserState;
        }
    }
}
