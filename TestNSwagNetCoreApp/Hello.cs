﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TestNSwagNetCoreApp
{
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using System;
    /// <summary>
    /// Using a base controller, the generated code is in Solution Items/ClientApi.cs
    /// </summary>
    [Produces("application/json")]
    [Route("[controller]/[action]")]
    public class BaseController : Controller
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class HelloController : BaseController
    {
        /// <summary>
        /// Returns a greeting message, as a JSON object
        /// </summary>
        /// <returns>The greeting message</returns>
        [HttpGet]
        public Task<HelloWorldModel> Model() => Task.FromResult(new HelloWorldModel());
        /// <summary>
        /// Returns null
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Task<HelloWorldModel?> NullableModel() => Task.FromResult(default(HelloWorldModel));
    }

    /// <summary>
    /// 
    /// </summary>
    [JsonObject(ItemRequired = Required.Always)]
    public class HelloWorldModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string Hello { get; set; } = "World";

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(Required = Required.AllowNull)]
        public string? Extra { get; set; }

        /// <summary>
        /// The expiration date
        /// </summary>
        public DateTime? ExpirationDate { get; set; }
    }
}