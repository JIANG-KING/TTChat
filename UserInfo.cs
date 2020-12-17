namespace SqlSeverFrame
{
    public class UserInfo
    {
        //用户名
        private string username;
        //获取用户名
        public string GetUserName()
        {
            return username;
        }
        //设置用户名
        public void SetUserName( string username)
        {
            this.username = username;
        }


        //密码
        private string Password;
        //获取密码
        public string GetPassword()
        {
            return Password;
        }
        //设置密码
        public void SetPassword(string Password)
        {
            this.Password = Password;
        }
        //登录状态
        private string UserState;

        public string GtUserState()
        {
            return UserState;
        }

        public void SetUserState(string UserState)
        {

            this.UserState = UserState;
        }
    }
}
