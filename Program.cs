using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace TaskScheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSellerCloudData();
        }

        public static void GetSellerCloudData()
        {
            var client = new RestClient("http://192.168.9.43//Dynamic_API/Parameter/");
            var request = new RestRequest("GetResults", Method.Post);
            request.AddParameter("url", "http://bh.api.sellercloud.com/rest/api/Orders?model.pageNumber=1&amp;model.pageSize=50&amp;model.createdOnFrom=2020/01/01&amp;model.createdOnTo=2022/05/24&amp;orderStatus=2&amp;shippingStatus=1&amp;paymentStatus=30&amp;dropshipStatus=0&amp;warehouseID=208");
            request.AddParameter("baseUri", "http://bh.api.sellercloud.com/rest");
            request.AddParameter("username", "onlsupport@oneilllogistics.com");
            request.AddParameter("password", "Aloha@12345678");
            request.AddParameter("provider", "sellercloud");
            request.AddParameter("apiId", 17);
            request.AddParameter("salesOrderFilters", "model.pageNumber=1&amp;model.pageSize=50&amp;model.createdOnFrom=2020/01/01&amp;model.createdOnTo=2022/05/24&amp;orderStatus=2&amp;shippingStatus=1&amp;paymentStatus=30&amp;dropshipStatus=0&amp;warehouseID=208&amp;");
            request.AddParameter("order", "Orders");


            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var josnData = response.Content;
                dynamic parsedJson = JsonConvert.DeserializeObject(josnData);
                parsedJson = parsedJson.Remove(0, 9);
                parsedJson = parsedJson.Substring(0, parsedJson.LastIndexOf(","));
                dynamic result = JsonConvert.DeserializeObject<List<SellerCloudOrderEntityDto>>(parsedJson);

                foreach (var item in result)
                {
                    GetSingleSellerCloudOrderData(item.ID);

                }
            }

        }

        public static void GetSingleSellerCloudOrderData(int OrderID)
        {
            var addOrderID = "http://bh.api.sellercloud.com/rest/api/Orders/" + OrderID + "";
            var client = new RestClient("http://192.168.9.43//Dynamic_API/Parameter/");
            var request = new RestRequest("GetResults", Method.Post);
            request.AddParameter("url", "http://bh.api.sellercloud.com/rest/api/Orders/"+ OrderID + "");
            request.AddParameter("baseUri", "http://bh.api.sellercloud.com/rest");
            request.AddParameter("username", "onlsupport@oneilllogistics.com");
            request.AddParameter("password", "Aloha@12345678");
            request.AddParameter("provider", "sellercloud");
            request.AddParameter("apiId", 18);
            request.AddParameter("salesOrderFilters", "id="+ OrderID + "&amp;");
            request.AddParameter("order", "SingleOrder");
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return;
            }
        }
    }
}