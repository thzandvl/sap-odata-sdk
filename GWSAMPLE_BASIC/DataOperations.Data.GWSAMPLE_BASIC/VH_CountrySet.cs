//EntitySet Generated by tool
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using DataOperations.OData; 
using DataOperations; 

namespace GWSAMPLE_BASIC
{

    public class VH_CountrySet : ODataEntitySetOperations<GWSAMPLE_BASIC.VH_Country>
    {
        public VH_CountrySet(IOperationsDispatcher dispatcher) : base(dispatcher)
        {
        }

    }
}