//AutoGenerated Code
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using DataOperations.OData; 
using DataOperations; 

namespace API_SALES_ORDER_SRV
{

    public static class DISetup
    {
        public static IServiceCollection RegisterSetsAsSingletons(this IServiceCollection services)
        {
            services.AddSingleton<ServiceRootSet>();
            services.AddSingleton<A_SalesOrder>();
            services.AddSingleton<A_SalesOrderHeaderPartner>();
            services.AddSingleton<A_SalesOrderHeaderPrElement>();
            services.AddSingleton<A_SalesOrderItem>();
            services.AddSingleton<A_SalesOrderItemPartner>();
            services.AddSingleton<A_SalesOrderItemPrElement>();
            services.AddSingleton<A_SalesOrderItemRelatedObject>();
            services.AddSingleton<A_SalesOrderItemText>();
            services.AddSingleton<A_SalesOrderRelatedObject>();
            services.AddSingleton<A_SalesOrderScheduleLine>();
            services.AddSingleton<A_SalesOrderText>();
            services.AddSingleton<A_SlsOrdPaymentPlanItemDetails>();
            return services;
        }
    }
}