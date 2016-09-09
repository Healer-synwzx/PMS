﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using PMS.Model;

namespace WFTest
{

    public sealed class QueryState_BookMark<T> : NativeActivity
    {
        // 定义一个字符串类型的活动输入参数
        public InArgument<string> Text { get; set; }

        /// <summary>
        /// 工作流名称
        /// </summary>
        public InOutArgument<string> BookMarkName { get; set; }

        public OutArgument<int> SetpId { get; set; }

        public OutArgument<T> State { get; set; }

        protected override void Execute(NativeActivityContext context)
        {
            //1 从当前的上下文对象中获取指定名称的书签
            string bookMarkName = context.GetValue(BookMarkName);
            //2 创建书签
            context.CreateBookmark(bookMarkName, new BookmarkCallback(ContinueExecuteWF));
        }

        /// <summary>
        /// 需要重写此方法并返回true，否则工作流无法执行异步操作
        /// </summary>
        protected override bool CanInduceIdle
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// 恢复bookmark后调用的方法
        /// </summary>
        /// <param name="context"></param>
        /// <param name="bookmark"></param>
        /// <param name="value"></param>
        public void ContinueExecuteWF(
    NativeActivityContext context,
    Bookmark bookmark,object value)
        {
            //继续执行查询方法
            var data = (PMS.Model.WFModel.BookMarkObj<T>)value;

            context.SetValue(BookMarkName, data.BookMarkName);

            context.SetValue(SetpId, data.StepId);

            context.SetValue(State, data.State);
        }

    }
}
