using System;
using ServiceStack;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;
using ServiceStack.OrmLite;

namespace devBuilder.ServiceModel.DataModel
{
    [Alias("ddf_Form")]
    public sealed class Form: BaseEntity,IHasIntId
    {
        public Form()
        {
            CreateTime = DateTime.Now;
            ModifyTime = DateTime.Now;
            CreateUserId = 0;
            ModifyUserId = 0;
            Disable = false;
            WorkspaceId = 0;
        }

        public Form(string name, string code=null, string description = "") : this()
        {
            Name = name;
            Code = code?? name.Replace(" ","").ToCamelCase();
            Description = description;
        }

        /// <summary>
        /// form code 
        /// </summary>
        [StringLength(256)]
        public string Code { get; set; }
        /// <summary>
        /// Form title
        /// </summary>
        [StringLength(256)]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [StringLength(2048)]
        public string Description { get; set; }
        // api 
        
        /// <summary>
        /// Source Entity code if existing
        /// </summary>
        [StringLength(256)]
        public string RegardingSource { get; set; }
        /// <summary>
        /// Support string and Json object
        /// Default method: POST, GET, PUT, DELETE
        /// Json
        /// <example>
        /// {
        ///     create: { webhook: "", method: "POST" },
        ///     update: { webhook: "", method: "POST" },
        ///     delete: { webhook: "", method: "POST" },
        ///     get: { webhook: "", method: "POST" }
        /// }
        /// </example>
        /// </summary>
        [CustomField(OrmLiteVariables.MaxTextUnicode)]
        public string WebhookUrls { get; set; }

        // layout 
        
        /// <summary>
        /// Icon css class
        /// </summary>
        [StringLength(256)]
        public string Icon { get; set; }
        /// <summary>
        /// form container template
        /// card or tabs
        /// </summary>
        [CustomField(OrmLiteVariables.MaxTextUnicode)]
        public string Container { get; set; }
        /// <summary>
        /// Json format (DxForm Configuration)
        /// </summary>
        [CustomField(OrmLiteVariables.MaxTextUnicode)]
        public string Options { get; set; }
        
        // OP
        
        /// <summary>
        /// buttons in form toolbar
        /// </summary>
        [CustomField(OrmLiteVariables.MaxTextUnicode)]
        public string Buttons { get; set; }
    }
}