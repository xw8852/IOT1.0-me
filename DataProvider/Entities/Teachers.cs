﻿using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Entities
{
   
    //教师表
		public class Teachers
	{
	
      	/// <summary>
		/// 教师号
        /// </summary>
        public virtual string ID
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 教师姓名
        /// </summary>
        public virtual string name
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 性别，字典 1：男  2：女
        /// </summary>
        public virtual int sex
        {
            get; 
            set; 
        }        
		/// <summary>
		/// MobilePhone
        /// </summary>
        public virtual string MobilePhone
        {
            get; 
            set; 
        }        
		/// <summary>
		/// EntryDate
        /// </summary>
        public virtual DateTime? EntryDate
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 离职日期
        /// </summary>
        public virtual DateTime? LeaveDate
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 邮箱
        /// </summary>
        public virtual string Email
        {
            get; 
            set; 
        }        
		/// <summary>
		/// WeChat
        /// </summary>
        public virtual string WeChat
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 身份证号
        /// </summary>
        public virtual string IDNumber
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 联系地址
        /// </summary>
        public virtual string ContactAddress
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 备注
        /// </summary>
        public virtual string Remark
        {
            get; 
            set; 
        }        
		/// <summary>
		/// CreateTime
        /// </summary>
        public virtual DateTime? CreateTime
        {
            get; 
            set; 
        }        
		/// <summary>
		/// CreatorId
        /// </summary>
        public virtual string CreatorId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 绑定的账号，对应SYS_Account
        /// </summary>
        public virtual int? BindAccountID
        {
            get; 
            set; 
        }        
		   
	}

    /// <summary>
    /// Deploy：实体对象映射关系
    /// </summary>
    [Serializable]
    public sealed class TeachersORMMapper : ClassMapper<Teachers>
    {
        public TeachersORMMapper()
        {
            base.Table("Teachers");

            //Map(f => f.socketouts).Ignore();//设置忽略
            Map(f => f.ID).Key(KeyType.Assigned);//设置主键  (如果主键名称不包含字母“ID”，请设置)      
            AutoMap();
        }
    }
}