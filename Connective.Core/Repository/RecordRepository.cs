using Connective.Core.Infastructure;
using Connective.Data.Model.ApiStructure;
using System;
using System.Collections.Generic;
using Connective.Core.ExtensionMethods;
using System.Text;
using System.Linq;
using Connective.Data.Model;
using Connective.Data.Model.ApiResponse;

namespace Connective.Core.Repository
{
    public class RecordRepository : IRecordRepository
    {
        public void deleteRecords(string id)
        {

           ZohoApi.APIMethod("Leads", "deleteRecords",id, new List<ApiParameters> ()  );
        }

        public Record getRecordById(Record obj,string specific)
        {
            
            #region convert Record class to ApiParameters 
            var parameters = Convertions.ConvertToApiParameters(obj);
            parameters.selected_attr = "(" + specific + ")";
           
            #endregion

            #region convert result to Record
            List<ApiParameters> parameterList = new List<ApiParameters> { parameters };
            



            
            var result =Convertions.ConvertToRecord(ZohoApi.APIMethod("Leads", "getRecordById", obj.Id.ToString(), parameterList), "getRecordById");
            #endregion
            var asd = result.FirstOrDefault();

            return result.FirstOrDefault();
            
        }

        public IEnumerable<Record> getRecords(string obj)
        {
            //#region convert Record class to ApiParameters 
            //var parameters = Convertions.convertToApiaparameters(obj);
            //#endregion
            var apiparams=  Convertions.ConvertToApiParameters(obj);
            
            #region convert result to Record
            List<ApiParameters> parameterList = new List<ApiParameters> { apiparams };
       
            //"<Leads><row no='1'>   <FL val='LEADID'>2000000022020</FL>  <FL val='SMOWNERID'>2000000018005</FL>  <FL val='Lead Owner'>John</FL>   <FL val='Company'>Zillium</FL>    <FL val='First Name'>Scott</FL>   <FL val='Last Name'>James</FL>      <FL val='No of Employees'>10</FL> <FL val='Annual Revenue'>1000.0</FL> <FL val='SMCREATORID'>2000000016908</FL>  <FL val='Created By'>John</FL>  <FL val='Created Time'>2010-03-16 10:04:52</FL><FL val='Modified Time'>2010-03-16 10:04:52</FL> </row>  </Leads>"
            var result = Convertions.ConvertToRecord(ZohoApi.APIMethod("Leads", "getRecords", "", parameterList), "getRecords");
         
            #endregion


            return result;
        }

        public List<Record> insertRecords(List<Record> obj)
        {
            #region convert Record class to ApiParameters 
            var parameters = Convertions.ConvertToApiParameters(obj,"insertRecords");
            #endregion

            #region convert result to Record
            var result =Convertions.ConvertToRecord(ZohoApi.APIMethod("Leads", "insertRecords", "", parameters), "insertRecords");


            #endregion


            return result;
        }

      
    
        public List<Record> updateRecords(Record obj)
        {
            #region convert Record class to ApiParameters 
            List<Record> list = new List<Record> { obj };
         
            var parameters = Convertions.ConvertToApiParameters(list, "updateRecords");
            #endregion

            #region convert result to Record
            List<ApiParameters> responseList = new List<ApiParameters>();

            responseList = parameters;
            //
  
            var result = Convertions.ConvertToRecord(ZohoApi.APIMethod("Leads", "updateRecords", obj.Id.ToString(), responseList), "updateRecords");


            #endregion


            return result;
        }
    }
}
