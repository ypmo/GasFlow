namespace GasFlow.Sim.Own.Tests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Energistics.DataAccess;
    using Energistics.DataAccess.PRODML210.ComponentSchemas;
    using Energistics.DataAccess.PRODML210.ReferenceData;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;
    using Energistics.DataAccess.PRODML210;

    public class ChokeSimTests
    {
        [Fact]
        public async Task Test1()
        {
            var sim = new OwnSim();
            GasFlow.Sim.Dto.SimInput model = new();
            var volume = await sim.Simulate(model, CancellationToken.None);
            Assert.NotNull(volume);

        }

        private ProductFlowModel ChokeModel()
        {
            var model = new ProductFlowModel()
            {
                Uuid = "M-Chock-01",
                Network = new List<ProductFlowNetwork>()
                {
                    new()
                    {
                        Uid = "01",
                        Name="N_Choke_01",
                        Port=new List<ProductFlowExternalPort>()
                        {
                            new()
                            {
                                Uid ="inP1",
                                Direction=ProductFlowPortType.inlet,
                            },
                            new()
                            {
                                Uid="out01",
                                Direction=ProductFlowPortType.outlet
                            }
                        },
                        Unit=new List<ProductFlowUnit>()
                        {
                            new()
                            {
                                Uid="01",
                                Port=new List<ProductFlowPort>()
                                {
                                    new()
                                    {
                                        Uid="inP1",
                                        Direction=ProductFlowPortType.inlet
                                    },
                                    new()
                                    {
                                        Uid="out01",
                                        Direction= ProductFlowPortType.outlet
                                    }
                                }
                            }
                        }
                    }
                }
            };
            return model;
        }

        private ProductVolume GetVolume()
        {
            ProductVolume volume = new()
            {
                ProductFlowModel = new DataObjectReference()
                {
                    Uuid = "M-Chock-01"
                },
                Facility = new List<ProductVolumeFacility>()
                {
                    new()
                    {
                        Flow = new List<ProductVolumeFlow>()
                        {
                            new()
                            {
                                Properties = new CommonPropertiesProductVolume()
                                {
                                    FlowRateValue = new List<FlowRateValue>()
                                    {
                                        new()
                                        {
                                            FlowRate = new VolumePerTimeMeasure(100, VolumePerTimeUom.Item1000m3d.XMLName()),
                                            MeasurementPressureTemperature = new TemperaturePressure()
                                            {
                                                Pressure = new PressureMeasure(10, PressureUom.at.XMLName()),
                                                Temperature = new ThermodynamicTemperatureMeasure(20, ThermodynamicTemperatureUom.degC)
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            return volume;
        }
    }
}
