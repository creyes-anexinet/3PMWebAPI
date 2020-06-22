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
                                                Name = "KPI 1",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    Dimensions = new Dictionary<string, string>() {
                                                        { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "MainValue" },
                                                        { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "UpperValue" },
                                                        { "74d3d52a-c8e8-4281-a63a-27f4aaca91f8", "LowerValue" }
                                                    },
                                                    Measure = new List<Dictionary<string, string>>() { new Dictionary<string, string>() {
                                                            { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "$986,720" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "+$106,720" },
                                                            { "74d3d52a-c8e8-4281-a63a-27f4aaca91f8", "+7.6%" }
                                                        }
                                                    }
                                                },
                                                Properties = new ResourceObjectProperties()
                                            },
                                            new ResourceObject()
                                            {
                                                Id = "2b9adb45-cc56-44d5-84e4-f1d52bff4e09",
                                                Name = "Vertical Bar Chart",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    Dimensions = new Dictionary<string, string>() {
                                                        { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "Jan" },
                                                        { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "Feb" },
                                                        { "9f9e69dd-4153-4001-b88e-6907408c7439", "Mar" },
                                                        { "e3a9a989-7437-4c1b-97eb-b1026cced4f2", "Apr" },
                                                        { "e1cd40d2-90f7-405e-a17f-6321a48ee2f1", "May" },
                                                        { "456691d2-d178-4d9e-bd4c-4e6eece63acc", "Jun" }
                                                    },
                                                    Measure = new List<Dictionary<string, string>>() { new Dictionary<string, string>() {
                                                            { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "52%" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "17%" },
                                                            { "9f9e69dd-4153-4001-b88e-6907408c7439", "11%" },
                                                            { "e3a9a989-7437-4c1b-97eb-b1026cced4f2", "68%" },
                                                            { "e1cd40d2-90f7-405e-a17f-6321a48ee2f1", "50%" },
                                                            { "456691d2-d178-4d9e-bd4c-4e6eece63acc", "27%" }
                                                        }
                                                    }
                                                },
                                                Properties = new ResourceObjectProperties()
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
                                                Id = "2b9adb45-cc56-44d5-84e4-f1d52bff4e09",
                                                Name = "Horizontal Bar Chart",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    Dimensions = new Dictionary<string, string>() {
                                                        { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "5x5" },
                                                        { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "5x10" },
                                                        { "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", "5x15" },
                                                        { "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", "10x10" },
                                                        { "9b61760c-dab5-4062-9b92-a059ae37fd75", "10x15" },
                                                        { "4faed222-9c75-4bf7-93d1-b205215cd2ad", "10x20" },
                                                        { "e855f79d-701d-4c18-9f2b-fe6484b4ac84", "10x25" },
                                                        { "5d4673e2-38df-4659-a68e-92468dd78eb9", "10x30" }
                                                    },
                                                    Measure = new List<Dictionary<string, string>> {
                                                        new Dictionary<string, string>() {
                                                            { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "51" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "65" },
                                                            { "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", "93" },
                                                            { "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", "70" },
                                                            { "9b61760c-dab5-4062-9b92-a059ae37fd75", "22" },
                                                            { "4faed222-9c75-4bf7-93d1-b205215cd2ad", "30" },
                                                            { "e855f79d-701d-4c18-9f2b-fe6484b4ac84", "96" },
                                                            { "5d4673e2-38df-4659-a68e-92468dd78eb9", "90" }
                                                        }
                                                    }
                                                },
                                                Properties = new ResourceObjectProperties()
                                            },
                                            new ResourceObject()
                                            {
                                                Id = "2b9adb45-cc56-44d5-84e4-f1d52bff4e09",
                                                Name = "Stacked Horizontal Bar Chart",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    Dimensions = new Dictionary<string, string>() {
                                                        { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "5x5" },
                                                        { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "5x10" },
                                                        { "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", "5x15" },
                                                        { "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", "10x10" },
                                                        { "9b61760c-dab5-4062-9b92-a059ae37fd75", "10x15" },
                                                        { "4faed222-9c75-4bf7-93d1-b205215cd2ad", "10x20" },
                                                        { "e855f79d-701d-4c18-9f2b-fe6484b4ac84", "10x25" },
                                                        { "5d4673e2-38df-4659-a68e-92468dd78eb9", "10x30" }
                                                    },
                                                    Measure = new List<Dictionary<string, string>> {
                                                        new Dictionary<string, string>() {
                                                            { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "51" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "65" },
                                                            { "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", "93" },
                                                            { "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", "70" },
                                                            { "9b61760c-dab5-4062-9b92-a059ae37fd75", "22" },
                                                            { "4faed222-9c75-4bf7-93d1-b205215cd2ad", "30" },
                                                            { "e855f79d-701d-4c18-9f2b-fe6484b4ac84", "96" },
                                                            { "5d4673e2-38df-4659-a68e-92468dd78eb9", "90" }
                                                        },
                                                        new Dictionary<string, string>() {
                                                            { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "52" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "64" },
                                                            { "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", "91" },
                                                            { "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", "71" },
                                                            { "9b61760c-dab5-4062-9b92-a059ae37fd75", "25" },
                                                            { "4faed222-9c75-4bf7-93d1-b205215cd2ad", "35" },
                                                            { "e855f79d-701d-4c18-9f2b-fe6484b4ac84", "94" },
                                                            { "5d4673e2-38df-4659-a68e-92468dd78eb9", "94" }
                                                        },
                                                        new Dictionary<string, string>() {
                                                            { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "53" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "67" },
                                                            { "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", "95" },
                                                            { "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", "74" },
                                                            { "9b61760c-dab5-4062-9b92-a059ae37fd75", "23" },
                                                            { "4faed222-9c75-4bf7-93d1-b205215cd2ad", "31" },
                                                            { "e855f79d-701d-4c18-9f2b-fe6484b4ac84", "92" },
                                                            { "5d4673e2-38df-4659-a68e-92468dd78eb9", "97" }
                                                        }
                                                    }

                                                },
                                                Properties = new ResourceObjectProperties()
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
