using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Text;

namespace PlsCan_Run
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1
    {
        DataClasses2DataContext tdv = new DataClasses2DataContext();

        // Add more operations here and mark them with [OperationContract]
        #region Get_All_Sales
        [OperationContract]

        List<Route> Get_All_Sales()
        {
            var Show_All = from NV in tdv.Routes
                           select NV;
            return Show_All.ToList();
        }
        #endregion

        #region Get_Find_Destination(string Names)

        [OperationContract]
        List<Route> Get_Find_Destination(string Names)
        {
            var Find_Names = from NVS in tdv.Routes
                             where NVS.routeID.StartsWith(Names)
                             select NVS;

            return Find_Names.ToList();
        }

        #endregion
    }
}
