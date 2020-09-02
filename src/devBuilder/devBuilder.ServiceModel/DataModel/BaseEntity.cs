using System;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;

namespace devBuilder.ServiceModel.DataModel
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseEntity
    {
        [AutoIncrement]
        public virtual int Id { get; set; }
        [Index]
        public virtual int WorkspaceId { get; set; }
        [Default(0)]
        public virtual bool Disable { get; set; }
        [Default(OrmLiteVariables.SystemUtc)]
        public virtual DateTimeOffset CreateTime { get; set; }
        [Default(0)]
        public virtual int CreateUserId { get; set; }
        [Default(0)]
        public virtual  int ModifyUserId { get; set; }
        [Default(OrmLiteVariables.SystemUtc)]
        public virtual DateTimeOffset ModifyTime { get; set; }
        [RowVersion]
        public virtual ulong RowVersion { get; set; }

    }
}