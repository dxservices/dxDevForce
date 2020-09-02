using System.Collections.Generic;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;
using ServiceStack.OrmLite;

namespace devBuilder.ServiceModel.DataModel
{
    /// <summary>
    /// 
    /// </summary>
    [Alias("ddf_FormItem")]
    public class FormItem : BaseEntity, IHasIntId
    {
        public FormItem()
        {

        }

        [Index] 
        public int FormId { get; set; }

        /// <summary>
        /// Label or Caption
        /// </summary>
        [StringLength(256)]
        public string Name { get; set; }
        
        [StringLength(256)] 
        public string Code { get; set; }
        [StringLength(2048)] 
        public string Description { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ParentId { get; set; }

        // Data
        public DataType DataType { get; set; }

        /// <summary>
        /// string or Json
        /// value = data.field1
        /// </summary>
        public string DefaultValue { get; set; }
        
        /// <summary>
        /// Editor
        /// </summary>
        public EditorType EditorType { get; set; }
        [CustomField(OrmLiteVariables.MaxTextUnicode)]
        public string EditorOptions { get; set; }
        
        /// <summary>
        /// Validation Rules
        /// </summary>
        [CustomField(OrmLiteVariables.MaxTextUnicode)]
        public string Validations { get; set; }
        /// <summary>
        /// Action or event
        /// </summary>
        [CustomField(OrmLiteVariables.MaxTextUnicode)]
        public string Logical { get; set; }
        
        // UI Options
        /// <summary>
        /// Final FormItem options
        /// </summary>
        [CustomField(OrmLiteVariables.MaxTextUnicode)]
        public string ItemOptions { get; set; }

        
    }
}
