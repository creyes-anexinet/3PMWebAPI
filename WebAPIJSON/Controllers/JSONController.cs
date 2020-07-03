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

            ResourceData qlikData = new ResourceData()
            {
                Streams = new List<ResourceStream>()
                {
                    new ResourceStream() {
                        Id = "1ea7cac3-8f23-4e48-8e8a-84da319a0785",
                        Applications = new List<ResourceApp>
                        {
                            new ResourceApp() {
                                Id = "9d129694-3829-44be-9ed1-7305a2e8c794",
                                Sheets = new List<ResourceSheet>
                                {
                                    new ResourceSheet() {
                                        Objects = new List<ResourceObject>
                                        {
                                            // KPI
                                            new ResourceObject()
                                            {
                                                Id = "5feda11c-f105-4ea9-b46b-465b59473498",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    Measure = new List<Dictionary<string, string>>() { new Dictionary<string, string>() {
                                                            { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "$986,720" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "+$106,720" },
                                                            { "9f9e69dd-4153-4001-b88e-6907408c7439", "+7.6%" }
                                                        }
                                                    }
                                                }
                                            },
                                            // Bar Chart with optional Budget
                                            new ResourceObject()
                                            {
                                                Id = "2b9adb45-cc56-44d5-84e4-f1d52bff4e09",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    TopperValue = "96%", // Dotted line
                                                    Dimensions = new List<ResourceDimension>() {
                                                        new ResourceDimension() { Id = "5a20d50c-0c50-4702-91f3-d7368c8a4b70", Caption = "Jan" },
                                                        new ResourceDimension() { Id = "0aa7afde-3ac2-43e8-baa1-285c378ae864", Caption = "Feb" },
                                                        new ResourceDimension() { Id = "9f9e69dd-4153-4001-b88e-6907408c7439", Caption = "Mar" },
                                                        new ResourceDimension() { Id = "e3a9a989-7437-4c1b-97eb-b1026cced4f2", Caption = "Apr" },
                                                        new ResourceDimension() { Id = "e1cd40d2-90f7-405e-a17f-6321a48ee2f1", Caption = "May" },
                                                        new ResourceDimension() { Id = "456691d2-d178-4d9e-bd4c-4e6eece63acc", Caption = "Jun" }
                                                    },
                                                    Measure = new List<Dictionary<string, string>>() { new Dictionary<string, string>() {
                                                            { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "52%" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "17%" },
                                                            { "9f9e69dd-4153-4001-b88e-6907408c7439", "11%" },
                                                            { "e3a9a989-7437-4c1b-97eb-b1026cced4f2", "68%" },
                                                            { "e1cd40d2-90f7-405e-a17f-6321a48ee2f1", "50%" },
                                                            { "456691d2-d178-4d9e-bd4c-4e6eece63acc", "27%" }
                                                        }
                                                    },
                                                    // Text to specify a graphic reading help
                                                    HelpTips = new Dictionary<string, string>() {
                                                        { "5ef86250-f844-40e7-aa67-7f26af310a4e", "- - - Budget" }
                                                    }
                                                }
                                            },
                                            // Horizontal Bar Chart with optional Budget
                                            new ResourceObject()
                                            {
                                                Id = "2b9adb45-cc56-44d5-84e4-f1d52bff4e09",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    TopperValue = "96%", // Dotted line level
                                                    Dimensions = new List<ResourceDimension>() {
                                                        new ResourceDimension() { Id = "5a20d50c-0c50-4702-91f3-d7368c8a4b70", Caption = "5x5" },
                                                        new ResourceDimension() { Id = "0aa7afde-3ac2-43e8-baa1-285c378ae864", Caption = "5x10" },
                                                        new ResourceDimension() { Id = "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", Caption = "5x15" },
                                                        new ResourceDimension() { Id = "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", Caption = "10x10" },
                                                        new ResourceDimension() { Id = "9b61760c-dab5-4062-9b92-a059ae37fd75", Caption = "10x15" },
                                                        new ResourceDimension() { Id = "4faed222-9c75-4bf7-93d1-b205215cd2ad", Caption = "10x20" },
                                                        new ResourceDimension() { Id = "e855f79d-701d-4c18-9f2b-fe6484b4ac84", Caption = "10x25" },
                                                        new ResourceDimension() { Id = "5d4673e2-38df-4659-a68e-92468dd78eb9", Caption = "10x30" }
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
                                                    },
                                                    // Text to specify a graphic reading help
                                                    HelpTips = new Dictionary<string, string>() {
                                                        { "5ef86250-f844-40e7-aa67-7f26af310a4e", "- - - Budget" }
                                                    }
                                                }
                                            },
                                            // Stacked Bar Chart
                                            new ResourceObject()
                                            {
                                                Id = "2b9adb45-cc56-44d5-84e4-f1d52bff4e09",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    Dimensions = new List<ResourceDimension>() {
                                                        new ResourceDimension() { Id = "5a20d50c-0c50-4702-91f3-d7368c8a4b70", Caption = "5x5" },
                                                        new ResourceDimension() { Id = "0aa7afde-3ac2-43e8-baa1-285c378ae864", Caption = "5x10" },
                                                        new ResourceDimension() { Id = "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", Caption = "5x15" },
                                                        new ResourceDimension() { Id = "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", Caption = "10x10" },
                                                        new ResourceDimension() { Id = "9b61760c-dab5-4062-9b92-a059ae37fd75", Caption = "10x15" },
                                                        new ResourceDimension() { Id = "4faed222-9c75-4bf7-93d1-b205215cd2ad", Caption = "10x20" },
                                                        new ResourceDimension() { Id = "e855f79d-701d-4c18-9f2b-fe6484b4ac84", Caption = "10x25" },
                                                        new ResourceDimension() { Id = "5d4673e2-38df-4659-a68e-92468dd78eb9", Caption = "10x30" }
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
                                                }
                                            },
                                            // Stacked Horizontal Bar Chart with optional Budget
                                            new ResourceObject()
                                            {
                                                Id = "2b9adb45-cc56-44d5-84e4-f1d52bff4e09",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    TopperValue = "96%", // Dotted line level
                                                    Dimensions = new List<ResourceDimension>() {
                                                        new ResourceDimension() { Id = "5a20d50c-0c50-4702-91f3-d7368c8a4b70", Caption = "5x5" },
                                                        new ResourceDimension() { Id = "0aa7afde-3ac2-43e8-baa1-285c378ae864", Caption = "5x10" },
                                                        new ResourceDimension() { Id = "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", Caption = "5x15" },
                                                        new ResourceDimension() { Id = "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", Caption = "10x10" },
                                                        new ResourceDimension() { Id = "9b61760c-dab5-4062-9b92-a059ae37fd75", Caption = "10x15" },
                                                        new ResourceDimension() { Id = "4faed222-9c75-4bf7-93d1-b205215cd2ad", Caption = "10x20" },
                                                        new ResourceDimension() { Id = "e855f79d-701d-4c18-9f2b-fe6484b4ac84", Caption = "10x25" },
                                                        new ResourceDimension() { Id = "5d4673e2-38df-4659-a68e-92468dd78eb9", Caption = "10x30" }
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
                                                    },
                                                    // Text to specify a graphic reading help
                                                    HelpTips = new Dictionary<string, string>() {
                                                        { "5ef86250-f844-40e7-aa67-7f26af310a4e", "- - - Budget" }
                                                    },
                                                }
                                            },
                                            // Single Horizontal Bar Chart
                                            new ResourceObject()
                                            {
                                                Id = "2b9adb45-cc56-44d5-84e4-f1d52bff4e09",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    Dimensions = new List<ResourceDimension>() {
                                                        new ResourceDimension() { Id = "5a20d50c-0c50-4702-91f3-d7368c8a4b70", Caption = "Fees" },
                                                        new ResourceDimension() { Id = "0aa7afde-3ac2-43e8-baa1-285c378ae864", Caption = "Waived Fees" }
                                                    },
                                                    Measure = new List<Dictionary<string, string>> {
                                                        new Dictionary<string, string>() {
                                                            { "5ef86250-f844-40e7-aa67-7f26af310a4e", "-2,000" },
                                                            { "d5cb9356-ff49-4099-a594-2c7949614e95", "14,000" }
                                                        }
                                                    }
                                                }
                                            },
                                            // Single Stacked Horizontal Bar Chart
                                            new ResourceObject()
                                            {
                                                Id = "2b9adb45-cc56-44d5-84e4-f1d52bff4e09",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    // Text to specify a graphic reading help
                                                    DimensionGroups = new Dictionary<string, string>() {
                                                        { "5ef86250-f844-40e7-aa67-7f26af310a4e", "REVENUE" },
                                                        { "b922eb88-a93e-47a6-ad18-8d79d1141642", "ALLOWANCES" }
                                                    },
                                                    Dimensions = new List<ResourceDimension>() {
                                                        new ResourceDimension() { Id = "5a20d50c-0c50-4702-91f3-d7368c8a4b70", Caption = "Accured Rent", GroupId = "5ef86250-f844-40e7-aa67-7f26af310a4e" },
                                                        new ResourceDimension() { Id = "0aa7afde-3ac2-43e8-baa1-285c378ae864", Caption = "Merchandise", GroupId = "5ef86250-f844-40e7-aa67-7f26af310a4e"  },
                                                        new ResourceDimension() { Id = "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", Caption = "Fees", GroupId = "5ef86250-f844-40e7-aa67-7f26af310a4e"  },
                                                        new ResourceDimension() { Id = "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", Caption = "Insurance", GroupId = "5ef86250-f844-40e7-aa67-7f26af310a4e" },
                                                        new ResourceDimension() { Id = "9b61760c-dab5-4062-9b92-a059ae37fd75", Caption = "Write-Offs", GroupId = "b922eb88-a93e-47a6-ad18-8d79d1141642"  },
                                                        new ResourceDimension() { Id = "4faed222-9c75-4bf7-93d1-b205215cd2ad", Caption = "Discounts", GroupId = "b922eb88-a93e-47a6-ad18-8d79d1141642"  }
                                                    },
                                                    Measure = new List<Dictionary<string, string>> {
                                                        new Dictionary<string, string>() {
                                                            { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "-10,000" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "-5,000" },
                                                            { "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", "300,000" },
                                                            { "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", "600,000" },
                                                            { "9b61760c-dab5-4062-9b92-a059ae37fd75", "555,000" },
                                                            { "4faed222-9c75-4bf7-93d1-b205215cd2ad", "123,000" }
                                                        }
                                                    }
                                                }
                                            },
                                            // Single Line Chart with optional Budget
                                            new ResourceObject()
                                            {
                                                Id = "2b9adb45-cc56-44d5-84e4-f1d52bff4e09",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    Dimensions = new List<ResourceDimension>() {
                                                        new ResourceDimension() { Id = "5a20d50c-0c50-4702-91f3-d7368c8a4b70", Caption = "Jan" },
                                                        new ResourceDimension() { Id = "0aa7afde-3ac2-43e8-baa1-285c378ae864", Caption = "Feb" },
                                                        new ResourceDimension() { Id = "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", Caption = "Mar" },
                                                        new ResourceDimension() { Id = "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", Caption = "Apr" },
                                                        new ResourceDimension() { Id = "9b61760c-dab5-4062-9b92-a059ae37fd75", Caption = "May" },
                                                        new ResourceDimension() { Id = "4faed222-9c75-4bf7-93d1-b205215cd2ad", Caption = "Jun" }
                                                    },
                                                    Measure = new List<Dictionary<string, string>> {
                                                        new Dictionary<string, string>() {
                                                            { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "72" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "58" },
                                                            { "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", "41" },
                                                            { "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", "52" },
                                                            { "9b61760c-dab5-4062-9b92-a059ae37fd75", "36" },
                                                            { "4faed222-9c75-4bf7-93d1-b205215cd2ad", "74" }
                                                        }
                                                    }
                                                }
                                            },
                                            // Multiple Line Chart
                                            new ResourceObject()
                                            {
                                                Id = "2b9adb45-cc56-44d5-84e4-f1d52bff4e09",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    Dimensions = new List<ResourceDimension>() {
                                                        new ResourceDimension() { Id = "5a20d50c-0c50-4702-91f3-d7368c8a4b70", Caption = "Jan" },
                                                        new ResourceDimension() { Id = "0aa7afde-3ac2-43e8-baa1-285c378ae864", Caption = "Feb" },
                                                        new ResourceDimension() { Id = "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", Caption = "Mar" },
                                                        new ResourceDimension() { Id = "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", Caption = "Apr" },
                                                        new ResourceDimension() { Id = "9b61760c-dab5-4062-9b92-a059ae37fd75", Caption = "May" },
                                                        new ResourceDimension() { Id = "4faed222-9c75-4bf7-93d1-b205215cd2ad", Caption = "Jun" }
                                                    },
                                                    Measure = new List<Dictionary<string, string>> {
                                                        new Dictionary<string, string>() {
                                                            { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "72" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "58" },
                                                            { "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", "41" },
                                                            { "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", "52" },
                                                            { "9b61760c-dab5-4062-9b92-a059ae37fd75", "36" },
                                                            { "4faed222-9c75-4bf7-93d1-b205215cd2ad", "74" }
                                                        },
                                                        new Dictionary<string, string>() {
                                                            { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "72" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "58" },
                                                            { "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", "41" },
                                                            { "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", "52" },
                                                            { "9b61760c-dab5-4062-9b92-a059ae37fd75", "36" },
                                                            { "4faed222-9c75-4bf7-93d1-b205215cd2ad", "74" }
                                                        },
                                                        new Dictionary<string, string>() {
                                                            { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "72" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "58" },
                                                            { "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", "41" },
                                                            { "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", "52" },
                                                            { "9b61760c-dab5-4062-9b92-a059ae37fd75", "36" },
                                                            { "4faed222-9c75-4bf7-93d1-b205215cd2ad", "74" }
                                                        }
                                                    }
                                                }
                                            },
                                            // Donut Chart
                                            new ResourceObject()
                                            {
                                                Id = "5feda11c-f105-4ea9-b46b-465b59473498",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    Measure = new List<Dictionary<string, string>> {
                                                        new Dictionary<string, string>() {
                                                            { "5ef86250-f844-40e7-aa67-7f26af310a4e", "86" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "6" }
                                                        }
                                                    }
                                                }
                                            },
                                            // Donut Chart with Legend
                                            new ResourceObject()
                                            {
                                                Id = "2b9adb45-cc56-44d5-84e4-f1d52bff4e09",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    Dimensions = new List<ResourceDimension>() {
                                                        new ResourceDimension() { Id = "5a20d50c-0c50-4702-91f3-d7368c8a4b70", Caption = "Online" },
                                                        new ResourceDimension() { Id = "0aa7afde-3ac2-43e8-baa1-285c378ae864", Caption = "In Person" }
                                                    },
                                                    Measure = new List<Dictionary<string, string>> {
                                                        new Dictionary<string, string>() {
                                                            { "5ef86250-f844-40e7-aa67-7f26af310a4e", "9,000" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "6,000" }
                                                        },
                                                        new Dictionary<string, string>() {
                                                            { "5ef86250-f844-40e7-aa67-7f26af310a4e", "60%" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "40%" }
                                                        }
                                                    }
                                                }
                                            },
                                            // Table
                                            new ResourceObject()
                                            {
                                                Id = "2b9adb45-cc56-44d5-84e4-f1d52bff4e09",
                                                Layout = new ResourceObjectLayout()
                                                {
                                                    // Text to specify a graphic reading help
                                                    DimensionGroups = new Dictionary<string, string>() {
                                                        { "5ef86250-f844-40e7-aa67-7f26af310a4e", "REVENUE" },
                                                        { "b922eb88-a93e-47a6-ad18-8d79d1141642", "TOTAL" },
                                                        { "d70e3d98-3565-4e82-90b6-443783a99adb", "BUDGET" }
                                                    },
                                                    Dimensions = new List<ResourceDimension>() {
                                                        new ResourceDimension() { Id = "5a20d50c-0c50-4702-91f3-d7368c8a4b70", Caption = "Accured Rent", GroupId = "5ef86250-f844-40e7-aa67-7f26af310a4e" },
                                                        new ResourceDimension() { Id = "0aa7afde-3ac2-43e8-baa1-285c378ae864", Caption = "Merchandise", GroupId = "5ef86250-f844-40e7-aa67-7f26af310a4e"  },
                                                        new ResourceDimension() { Id = "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", Caption = "Fees", GroupId = "5ef86250-f844-40e7-aa67-7f26af310a4e"  },
                                                        new ResourceDimension() { Id = "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", Caption = "Insurance", GroupId = "5ef86250-f844-40e7-aa67-7f26af310a4e" }
                                                    },
                                                    Measure = new List<Dictionary<string, string>> {
                                                        new Dictionary<string, string>() {
                                                            { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "$143,712" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "$150,00" },
                                                            { "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", "$50,000" },
                                                            { "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", "$10,000" }
                                                        },
                                                        new Dictionary<string, string>() {
                                                            { "5a20d50c-0c50-4702-91f3-d7368c8a4b70", "+2.3%" },
                                                            { "0aa7afde-3ac2-43e8-baa1-285c378ae864", "+0.5%" },
                                                            { "5a895e4d-73ee-4209-b8ad-f8fd4ed0d44e", "-1.1%" },
                                                            { "35f88e1c-e8ab-47a7-95d2-ad9f8acde46d", "+1.3%" }
                                                        }
                                                    }
                                                }
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