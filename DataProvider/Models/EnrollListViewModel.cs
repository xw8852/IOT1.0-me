﻿using DataProvider.Entities;
using DataProvider.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataProvider.Models
{
   public  class EnrollListViewModel
    {
       /// <summary>
       /// 页面的搜索条件
       /// </summary>
       public EnrollListSearchModel search = new EnrollListSearchModel();

       /// <summary>
       /// 页面的列表数据
       /// </summary>
       public PagedList<Appointment> AppointmentList { get; set; }
       /// <summary>
       /// 跟进方式下拉框
       /// </summary>
       public List<SelectListItem> FollowTypeIL { get; set; }
       /// <summary>
       /// 意向分类下拉框
       /// </summary>
       public List<SelectListItem> IntentTypeIL { get; set; }

       /// <summary>
       /// 待添加的跟进纪录
       /// </summary>
       public FollowRecord FollowRecordForADD { get; set; }
    }

   public class EnrollListSearchModel : CommonPageEntity
   {
       /// <summary>
       /// 学员姓名
       /// </summary>
       public string ApName { set; get; }
       /// <summary>
       /// 联系电话
       /// </summary>
       public string ApTel { set; get; }

   }
}
