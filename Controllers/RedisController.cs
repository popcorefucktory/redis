using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Web.Http; 

namespace WebApplication2
{
    public class RedisController : ApiController
    {
        // GET: api/Redis/key 
        public string Get(string key)
        {

            using (var redis = new RedisClient("localhost", 6379))
            {
                return redis.GetValue(key);
            }
        }

        // POST: api/Redis 
        public void Post(string key, string keyValue)
        {
            using (var redis = new RedisClient("localhost", 6379))
            {
                redis.SetValue(key, keyValue);
            }
        }
    }
}
