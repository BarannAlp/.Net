using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using project1.Dtos.Deneme;
using project1.Services;

namespace project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DenemeController : ControllerBase
    {
        IMathCalculaterService _mathCalculatorService;
        public DenemeController(IMathCalculaterService mathCalculaterService)
        {
            _mathCalculatorService = mathCalculaterService;
        }

        [HttpGet("SqrtResponseDto")]
        public SqrtResponseDto Sqrt(int sayi)
        {
            var sonuc = _mathCalculatorService.SqrtMethod(sayi);
            var response = new SqrtResponseDto();

            mongoinsert(sonuc, "Sqrt");
            response.Result = sonuc;
            response.Message = "Hesaplama Yapıldı";


            return response;
        }

        [HttpGet("FctrResponseDto")]
        public FctrResponseDto Fctr(int sayi2)
        {



            var sonuc = _mathCalculatorService.FctMethod(sayi2);
            mongoinsert(sonuc, "Fcrt");
            var response = new FctrResponseDto();


            response.Result = sonuc;
            response.Message = "Hesaplama Yapıldı";
            return response;


        }

        [HttpGet("ResetResponseDto")]
        public ResetResponseDto Reset(int sayi2)
        {



            int sonuc = 0;

            var response = new ResetResponseDto();


            response.Result = sonuc;

            return response;


        }



        [HttpGet("mongoinsert")]
        public void mongoinsert(double result, String operation)
        {

            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://barannalp:123baran123@cluster0.rkumy.mongodb.net/input?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("record");
            var collection = database.GetCollection<number>("calculations");



            var t = new number();
            t.result = result;
            t.operation = operation;

            collection.InsertOne(t);

        }

        
        [HttpGet("mongopull")]
        public async void mongopull()
        {

            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://barannalp:123baran123@cluster0.rkumy.mongodb.net/input?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("record");
            var collection = database.GetCollection<number>("calculations");
            String a = "Fctr";

            var results = await collection.FindAsync(c => c.id == a);
           
            foreach (var result in results.ToList())
            {
                Console.WriteLine(value: $"{result.id}: {result.result}: {result.operation}:");
            }




        }

    }
}






