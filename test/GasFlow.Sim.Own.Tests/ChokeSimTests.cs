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
    using prodml = Energistics.DataAccess.PRODML210;

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

        private prodml.ProductFlowModel ChokeModel()
        {
            var model = new prodml.ProductFlowModel()
            {
                Uuid = "M_Chocke_01",
                Network = new List<ProductFlowNetwork>()
                {
                    new ProductFlowNetwork()
                    {
                        Uid = "01",
                        Name="N_Choke_01",
                        Port=new List<ProductFlowExternalPort>()
                        {
                            new ProductFlowExternalPort()
                            {
                                Uid ="inP1",
                                Direction=ProductFlowPortType.inlet,
                            },
                            new ProductFlowExternalPort()
                            {
                                Uid="out01",
                                Direction=ProductFlowPortType.outlet
                            }
                        },
                        Unit=new List<ProductFlowUnit>()
                        {
                            new ProductFlowUnit()
                            {
                                Uid="01",
                                Port=new List<ProductFlowPort>()
                                {
                                    new ProductFlowPort()
                                    {
                                        Uid="inP1",
                                        Direction=ProductFlowPortType.inlet
                                    },
                                    new ProductFlowPort()
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

        private prodml.ProductVolume GetVolume()
        {
            var volume = new prodml.ProductVolume()
            {
                ProductFlowModel = new DataObjectReference
                {
                    Uuid = "M_Chocke_01"
                },
                Facility = new List<ProductVolumeFacility>()
                {
                    new ProductVolumeFacility()
                    {
                        Flow = new List<ProductVolumeFlow>()
                        {
                            new ProductVolumeFlow()
                            {
                                Properties = new CommonPropertiesProductVolume()
                                {
                                    FlowRateValue = new List<FlowRateValue>()
                                    {
                                        new FlowRateValue()
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
