//EntityType AutoGenerated by tool
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using DataOperations.OData; 
using DataOperations; 

namespace API_SALES_ORDER_SRV
{

    public class A_SalesOrderRelatedObjectType : BaseDTOWithIDAndETag
    {
        private string _SalesOrder;
        public string SalesOrder 
        { 
            get {
                return _SalesOrder;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("SalesOrder cannot be null and must have a value.");
                }
                if(value.Length > 10)
                {
                    throw new ValidationException("SalesOrder cannot be longer than 10 characters.");
                }
                else
                {
                    _SalesOrder = value;
                }
            }
        }
        private string _SDDocRelatedObjectSequenceNmbr;
        public string SDDocRelatedObjectSequenceNmbr 
        { 
            get {
                return _SDDocRelatedObjectSequenceNmbr;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("SDDocRelatedObjectSequenceNmbr cannot be null and must have a value.");
                }
                if(value.Length > 4)
                {
                    throw new ValidationException("SDDocRelatedObjectSequenceNmbr cannot be longer than 4 characters.");
                }
                else
                {
                    _SDDocRelatedObjectSequenceNmbr = value;
                }
            }
        }
        private string _SDDocumentRelatedObjectType;
        public string SDDocumentRelatedObjectType 
        { 
            get {
                return _SDDocumentRelatedObjectType;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("SDDocumentRelatedObjectType cannot be null and must have a value.");
                }
                if(value.Length > 5)
                {
                    throw new ValidationException("SDDocumentRelatedObjectType cannot be longer than 5 characters.");
                }
                else
                {
                    _SDDocumentRelatedObjectType = value;
                }
            }
        }
        private string _SDDocRelatedObjectSystem;
        public string SDDocRelatedObjectSystem 
        { 
            get {
                return _SDDocRelatedObjectSystem;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("SDDocRelatedObjectSystem cannot be null and must have a value.");
                }
                if(value.Length > 60)
                {
                    throw new ValidationException("SDDocRelatedObjectSystem cannot be longer than 60 characters.");
                }
                else
                {
                    _SDDocRelatedObjectSystem = value;
                }
            }
        }
        private string _SDDocRelatedObjectReference1;
        public string SDDocRelatedObjectReference1 
        { 
            get {
                return _SDDocRelatedObjectReference1;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("SDDocRelatedObjectReference1 cannot be null and must have a value.");
                }
                if(value.Length > 60)
                {
                    throw new ValidationException("SDDocRelatedObjectReference1 cannot be longer than 60 characters.");
                }
                else
                {
                    _SDDocRelatedObjectReference1 = value;
                }
            }
        }
        private string _SDDocRelatedObjectReference2;
        public string SDDocRelatedObjectReference2 
        { 
            get {
                return _SDDocRelatedObjectReference2;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("SDDocRelatedObjectReference2 cannot be null and must have a value.");
                }
                if(value.Length > 60)
                {
                    throw new ValidationException("SDDocRelatedObjectReference2 cannot be longer than 60 characters.");
                }
                else
                {
                    _SDDocRelatedObjectReference2 = value;
                }
            }
        }
        public Deferred<API_SALES_ORDER_SRV.A_SalesOrderType> to_SalesOrder {get; set;}


        protected override Dictionary<string, List<string>> ReferenceKeys 
        {   
            get 
            {
                var result = new Dictionary<string, List<string>>();
                result.Add("PrimaryKey", new List<string>() {"SalesOrder","SDDocRelatedObjectSequenceNmbr"});
                result.Add("to_SalesOrder", new List<string>() {"SalesOrder","SDDocRelatedObjectSequenceNmbr"});

                return result;
            }
        }


    }
}