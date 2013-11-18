using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CES.DataStructure
{
    public enum UserType
    {
        EVALUATOR,  //考评人
        EVALUATED,  //被考评人
        MANAGER,    //普通管理员
        SUPER       //超级管理员（领导）
    }
}
