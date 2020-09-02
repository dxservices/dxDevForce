using System.Collections.Generic;
using ServiceStack;

namespace devBuilder.ServiceModel.Form
{
    [Route("/form", "GET")]
    public class GetFormRequest : BaseRequest, IReturn<FormResponse>
    {
        public int Id { get; set; }
    }
    /// <summary>
    /// Create / Insert a new eneity
    /// </summary>
    [Route("/form", "POST")]
    public class CreateFormRequest : BaseRequest, IReturn<PostFormResponse>
    {
        public DataModel.Form Entity { get; set; }
    }
    /// <summary>
    /// Update entity
    /// </summary>
    [Route("/form/{Id}", "PUT")]
    [Route("/form", "PUT")]
    public class UpdateFormRequest : BaseRequest, IReturn<UpdateFormResponse>
    {
        public int Id { get; set; }
        
        public Dictionary<string, object> UpdateFields { get; set; }
    }
    /// <summary>
    /// Void / Delete Entity
    /// </summary>
    [Route("/form/{Id}", "DELETE")]
    [Route("/form", "DELETE")]
    public class DeleteFormRequest : BaseRequest, IReturn<BaseResponse>
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
    public class FormResponse : BaseResponse<DataModel.Form>
    {
        
    }
    /// <summary>
    /// Response for Insert / Create entity
    /// </summary>
    public class PostFormResponse : BaseResponse<DataModel.Form>
    {
        
    }
    /// <summary>
    /// Response for update entity
    /// </summary>
    public class UpdateFormResponse : BaseResponse<DataModel.Form>
    {
        
    }
    #endregion
}