using APIBdPickTheWinner.Domain;

namespace APIBdPickTheWinner.Interface;

public interface IUser
{
    List<User> List();

    bool LoginUserPwd(String User, String Pwd);
}
