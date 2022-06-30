using System;
using System.Collections.Generic;
using System.Text;

namespace YCProduction.Common.Helpers
{
    public interface IIdGenerator
    {
        /// <summary>
        /// 生成过程中产生的事件
        /// </summary>
        Action<OverCostActionArg> GenIdActionAsync { get; set; }

        /// <summary>
        /// 生成新的long型Id
        /// </summary>
        /// <returns></returns>
        long NewLong();

        // Guid NewGuid();
    }
    public class OverCostActionArg
    {
        /// <summary>
        /// 事件类型
        /// 1-开始，2-结束，8-漂移
        /// </summary>
        public virtual int ActionType { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        public virtual long TimeTick { get; set; }
        /// <summary>
        /// 机器码
        /// </summary>
        public virtual ushort WorkerId { get; set; }
        /// <summary>
        /// 漂移计算次数
        /// </summary>
        public virtual int OverCostCountInOneTerm { get; set; }
        /// <summary>
        /// 漂移期间生产ID个数
        /// </summary>
        public virtual int GenCountInOneTerm { get; set; }
        /// <summary>
        /// 漂移周期
        /// </summary>
        public virtual int TermIndex { get; set; }

        public OverCostActionArg(ushort workerId, long timeTick, int actionType = 0, int overCostCountInOneTerm = 0, int genCountWhenOverCost = 0, int index = 0)
        {
            ActionType = actionType;
            TimeTick = timeTick;
            WorkerId = workerId;
            OverCostCountInOneTerm = overCostCountInOneTerm;
            GenCountInOneTerm = genCountWhenOverCost;
            TermIndex = index;
        }
    }
}
