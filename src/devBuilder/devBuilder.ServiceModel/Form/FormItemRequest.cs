using System.Collections.Generic;
using ServiceStack;

namespace devBuilder.ServiceModel.Form
{
    [Route("/form/item", "GET")]
            public class GetFormItemRequest : BaseRequest, IReturn<FormItemResponse>
            {
                public int Id { get; set; }
            }
    
            /// <summary>
            /// Create / Insert a new eneity
            /// </summary>
            [Route("/form/item", "POST")]
            public class CreateFormItemRequest : BaseRequest, IReturn<PostFormItemResponse>
            {
                public DataModel.Form Entity { get; set; }
            }
    
            /// <summary>
            /// Update entity
            /// </summary>
            [Route("/form/item/{Id}", "PUT")]
            [Route("/form/item", "PUT")]
            public class UpdateFormItemRequest : BaseRequest, IReturn<UpdateFormItemResponse>
            {
                public int Id { get; set; }
    
                public Dictionary<string, object> UpdateFields { get; set; }
            }
    
            /// <summary>
            /// Void / Delete Entity
            /// </summary>
            [Route("/form/item/{Id}", "DELETE")]
            [Route("/form/item", "DELETE")]
            public class DeleteFormItemRequest : BaseRequest, IReturn<BaseResponse>
            {
                public int Id { get; set; }
    
                /// <summary>
                /// Default Disable = true
                /// </summary>
                public bool HardDelete { get; set; }
            }
    
            #region Response
    
            /// <summary>
            /// Entity Response
            /// </summary>
            public class FormItemResponse : BaseResponse<DataModel.FormItem>
            {
    
            }
    
            /// <summary>
            /// Response for Insert / Create entity
            /// </summary>
            public class PostFormItemResponse : BaseResponse<DataModel.FormItem>
            {
    
            }
    
            /// <summary>
            /// Response for update entity
            /// </summary>
            public class UpdateFormItemResponse : BaseResponse<DataModel.FormItem>
            {
    
            }
    
            #endregion
}