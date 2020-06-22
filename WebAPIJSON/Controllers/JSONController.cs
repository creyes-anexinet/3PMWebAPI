using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPIJSON.Entities;

namespace WebAPIJSON.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JSONController : ControllerBase
    {
        private readonly ILogger<JSONController> _logger;

        public JSONController(ILogger<JSONController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //After JSON Style or together

            ResourceData qlikData = new ResourceData() {
                Streams = new List<ResourceStream>()
                {
                    new ResourceStream() {
                        Id = "1ea7cac3-8f23-4e48-8e8a-84da319a0785",
                        Name = "3PM Stream",
                        Applications = new List<ResourceApp>
                        {
                            new ResourceApp() {
                                Id = "9d129694-3829-44be-9ed1-7305a2e8c794",
                                Name = "Regulations App",
                                Sheets = new List<ResourceSheet>
                                {
                                    new ResourceSheet() {
                                        Objects = new List<ResourceObject>
                                        {
                                            new ResourceObject()
                                            {
                                                Id = "5feda11c-f105-4ea9-b46b-465b59473498",
                                                Name = "My Chart",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    Dimensions = new Dictionary<string, string>() {
                                                        { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "January" },
                                                        { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "February" },
                                                        { "74d3d52a-c8e8-4281-a63a-27f4aaca91f8", "March" }
                                                    },
                                                    Measure = new Dictionary<string, string>() {
                                                        { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "1350" },
                                                        { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "4765" },
                                                        { "74d3d52a-c8e8-4281-a63a-27f4aaca91f8", "9364" }
                                                    }
                                                },
                                                Properties = new ResourceObjectProperties(),
                                                ObjectType = Enums.ResourceObjectTypes.Chart
                                            },
                                            new ResourceObject()
                                            {
                                                Id = "2b9adb45-cc56-44d5-84e4-f1d52bff4e09",
                                                Name = "My Chart 2",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    Id = "56c50f4c-bba0-4778-9a7b-4417c126a61c",
                                                    Name = "",
                                                    LayoutType = Enums.ResourceObjectLayoutTypes.LineChart,

                                                },
                                                Properties = new ResourceObjectProperties(),
                                                ObjectType = Enums.ResourceObjectTypes.Filter
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new ResourceStream() {
                        Id = "1ea7cac3-8f23-4e48-8e8a-84da319a0785",
                        Name = "CubeSmart Administrative Stream",
                        Applications = new List<ResourceApp>
                        {
                            new ResourceApp() {
                                Id = "9d129694-3829-44be-9ed1-7305a2e8c794",
                                Name = "Sales App",
                                Sheets = new List<ResourceSheet>
                                {
                                    new ResourceSheet() {
                                        Objects = new List<ResourceObject>
                                        {
                                            new ResourceObject()
                                            {
                                                Id = "d0e9c0f3-1318-43f7-9f8f-b4bb0ffa8a76",
                                                Name = "",
                                                Layout = new ResourceObjectLayout(),
                                                Properties = new ResourceObjectProperties(),
                                                ObjectType = Enums.ResourceObjectTypes.Chart
                                            },
                                            new ResourceObject()
                                            {
                                                Id = "3683201f-c699-4edc-8e2f-31e1f300ad54",
                                                Name = "",
                                                Layout = new ResourceObjectLayout(),
                                                Properties = new ResourceObjectProperties(),
                                                ObjectType = Enums.ResourceObjectTypes.Extension
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };

            return Ok(qlikData);
        }
    }
}
