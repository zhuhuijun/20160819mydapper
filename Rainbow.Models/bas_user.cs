/*******************************************************************************************
 * 此代码由T4模板自动生成
 * 对此文件的更改可能会导致不正确的行为，并且如果
 * 重新生成代码，这些更改将会丢失。
 * 日期:2016-07-29 10:43:09
 * 作者:huijun zhu<kngcbzdsn@outlook.com> 
 * 此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　                   
 * 版权所有：榆钱（北京）科技有限公司　　　　　　          
 * 此模板生成实体层:Rainbow.Models　　　　　                 
 * *******************************************************************************************/
using System;
using System.Collections.Generic;
namespace Rainbow.Models
{    
    /// <summary>
    /// 实体-bas_user 
    /// </summary>
    public partial class bas_user    
    {    
        public int userId { get; set; }
          public string UserName { get; set; }
          public string UserPwd { get; set; }
          public string Email { get; set; }
          public string PhoneNum { get; set; }
          public Boolean IsFirstTimeLogin { get; set; }
          public int AccessFailedCount { get; set; }
          public DateTime CreationDate { get; set; }
          public Boolean IsActive { get; set; }
    }
}
    
