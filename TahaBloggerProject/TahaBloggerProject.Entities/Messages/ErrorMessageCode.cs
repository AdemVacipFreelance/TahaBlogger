using System;
using System.Collections.Generic;
using System.Text;

namespace TahaBloggerProject.Entities.Messages
{
    public enum ErrorMessageCode
    {
        UsernameAlreadyExist=101,
        EmailAlreadyExist=102,
        UserIsNotActive =151,
        UsernameOrPassWrong=152,
        CheckYourEmail = 153,
        UserAlreadyActive = 154,
        ActivateIdDoesNotExist =155
    }
}
