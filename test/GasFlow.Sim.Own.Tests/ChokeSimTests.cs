using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Energistics.DataAccess.PRODML200.ComponentSchemas;
using Energistics.DataAccess.PRODML200.ReferenceData;
using Xunit;
using prodml = Energistics.DataAccess.PRODML200;
namespace GasFlow.Sim.Own.Tests
{
    public class ChokeSimTests
    {
        [Fact]
        public async Task Test1()
        {
            var sim = new OwnSim();
            var model = ChokeModel();
            var inVolume = GetVolume();
            var volume = await sim.CalcModel(model, inVolume);
            Assert.NotNull(volume);
        }


        prodml.ProductFlowModel ChokeModel()
        {
            var model = new prodml.ProductFlowModel()
            {
                Uuid = "M_Chocke_01",
                Network = new ObservableCollection<ProductFlowNetwork>()
                {
                    new ProductFlowNetwork()
                    {
                        Uid = "01",
                        Name="N_Choke_01",
                        Port=new ObservableCollection<ProductFlowExternalPort>()
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
                        Unit=new ObservableCollection<ProductFlowUnit>()
                        {
                            new ProductFlowUnit()
                            {
                                Uid="01",
                                Port=new ObservableCollection<ProductFlowPort>()
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

        prodml.ProductVolume GetVolume()
        {
            var volume = new prodml.ProductVolume()
            {
                ProductFlowModel = new DataObjectReference
                {
                    Uuid = "M_Chocke_01"
                },
                Facility = new ObservableCollection<ProductVolumeFacility>()
                {
                    new ProductVolumeFacility()
                    {
                        Flow = new ObservableCollection<ProductVolumeFlow>()
                        {
                            new ProductVolumeFlow()
                            {
                                Properties = new CommonPropertiesProductVolume()
                                {
                                    FlowRateValue = new ObservableCollection<FlowRateValue>()
                                    {
                                        new FlowRateValue()
                                        {
                                            FlowRate = new VolumePerTimeMeasure()
                                            {
                                                Uom = VolumePerTimeUom.Item1000m3d,
                                                Value = 100
                                            },
                                            MeasurementPressureTemperature = new TemperaturePressure()
                                            {
                                                Pressure = new PressureMeasure()
                                                {
                                                    Uom = PressureUom.at,
                                                    Value = 10
                                                },
                                                Temperature = new ThermodynamicTemperatureMeasure()
                                                {
                                                    Uom = ThermodynamicTemperatureUom.degC,
                                                    Value = 20
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
            return volume;
        }

    }
}
