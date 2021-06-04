using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework;
using System.Windows.Navigation;
using MyToolkit.Multimedia;
using System.IO.IsolatedStorage;


namespace AppChaves
{
    public partial class Page1 : PhoneApplicationPage
    {
        string nome = "";
        //Cria um objeto da classe IsolatedStorageSettings para armazenamento das chaves
        IsolatedStorageSettings iso = IsolatedStorageSettings.ApplicationSettings;

        public Page1()
        {
            InitializeComponent();
        }

        private void atualizaLista(string nome)
        {
            if (nome != "")
            {
                PageTitle.Text = nome;
                switch (nome)
                {
                    case "1ª Temporada":
                        {
                            LoadTestData1Temporada();
                        } break;
                    case "2ª Temporada":
                        {
                            LoadTestData2Temporada();
                        } break;
                    case "3ª Temporada":
                        {
                            LoadTestData3Temporada();
                        } break;
                    case "4ª Temporada":
                        {
                            LoadTestData4Temporada();
                        } break;
                    case "5ª Temporada":
                        {
                            LoadTestData5Temporada();
                        } break;
                    default:
                        break;
                }
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            YouTube.CancelPlay(); // used to reenable page
            IDictionary<string, string> param =
                this.NavigationContext.QueryString;
            if (param.ContainsKey("temporada"))
            {
                nome = param["temporada"].ToString();
            }
            base.OnNavigatedTo(e);
            atualizaLista(nome);
        }

        private ObservableCollection<MyListViewModel> myVM;

        //1temporada
        private void LoadTestData1Temporada()
        {
            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                myVM = new ObservableCollection<MyListViewModel> 
                  { 
                      new MyListViewModel
                          {
                              Field1 = CarregarImagem("H0fsRRkMnX4"),
                              tag1="Os Balões",  
                              duracao="20:04",
                              id="H0fsRRkMnX4",
                              sourceFav=carregaSourceFav("H0fsRRkMnX4"),
                              textFav=carregaTextFav("H0fsRRkMnX4"),
                          },
                          new MyListViewModel 
                          { 
                              Field1 = CarregarImagem("bFSkWp3nGzk"),
                              tag1="Insônia",
                              duracao="20:07",
                              id="bFSkWp3nGzk",
                              sourceFav=carregaSourceFav("bFSkWp3nGzk"),
                              textFav=carregaTextFav("bFSkWp3nGzk"),
                          },
                      new MyListViewModel 
                          { 
                              Field1 = CarregarImagem("dlocRjIcd0s"),
                              tag1="Uma Mosca no Café",
                              duracao="20:08",
                              id="dlocRjIcd0s",
                              sourceFav=carregaSourceFav("dlocRjIcd0s"),
                              textFav=carregaTextFav("dlocRjIcd0s"),
                          },
                          new MyListViewModel 
                          { 
                              Field1=CarregarImagem("yS-canvQsQE"),
                              tag1="O Cachorrinho Satanás",
                              duracao="20:03",
                              id="yS-canvQsQE",
                              sourceFav=carregaSourceFav("yS-canvQsQE"),
                              textFav=carregaTextFav("yS-canvQsQE"),
                          },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("rOTFWjxUPgk"),
                            tag1="Os Gesseiros",
                            duracao="19:56",
                            id="rOTFWjxUPgk",
                            sourceFav=carregaSourceFav("rOTFWjxUPgk"),
                              textFav=carregaTextFav("rOTFWjxUPgk"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("N2x3myi2FaI"),
                            tag1="A Barraca de Churros",
                            duracao="20:01",
                            id="N2x3myi2FaI",
                            sourceFav=carregaSourceFav("N2x3myi2FaI"),
                              textFav=carregaTextFav("N2x3myi2FaI"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("RvfCo6WbtvM"),
                            tag1="No Ritmo da Valsa",
                            duracao="22:02",
                            id="RvfCo6WbtvM",
                            sourceFav=carregaSourceFav("RvfCo6WbtvM"),
                              textFav=carregaTextFav("RvfCo6WbtvM"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("-8Jh37I-sj0"),
                            tag1="Falta de Água",
                            duracao="20:14",
                            id="-8Jh37I-sj0",
                            sourceFav=carregaSourceFav("-8Jh37I-sj0"),
                              textFav=carregaTextFav("-8Jh37I-sj0"),
                            
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("p7xu66KN39Y"),
                            tag1="O Jogo de Beisebol",
                            duracao="20:07",
                            id="p7xu66KN39Y",
                            sourceFav=carregaSourceFav("p7xu66KN39Y"),
                              textFav=carregaTextFav("p7xu66KN39Y"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("VK-QfFe9cSU"),
                            tag1="Lava-Rápido do Chaves",
                            duracao="22:04",
                            id="VK-QfFe9cSU",
                            sourceFav=carregaSourceFav("VK-QfFe9cSU"),
                              textFav=carregaTextFav("VK-QfFe9cSU"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("C6_LHea2H28"),
                            tag1="O Futebol Americano",
                            duracao="19:59",
                            id="C6_LHea2H28",
                            sourceFav=carregaSourceFav("C6_LHea2H28"),
                              textFav=carregaTextFav("C6_LHea2H28"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("FYrLcX1E5WU"),
                            tag1="O Ladrão da Vizinhança",
                            duracao="20:26",
                            id="FYrLcX1E5WU",
                            sourceFav=carregaSourceFav("FYrLcX1E5WU"),
                              textFav=carregaTextFav("FYrLcX1E5WU"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("Z_3dR_-wR64"),
                            tag1="A Mascote do Quico",
                            duracao="22:19",
                            id="Z_3dR_-wR64",
                            sourceFav=carregaSourceFav("Z_3dR_-wR64"),
                              textFav=carregaTextFav("Z_3dR_-wR64"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("3lIwFaE5axA"),
                            tag1="Fotos Boas, Mais ou Menos e Ruins",
                            duracao="22:00",
                            id="3lIwFaE5axA",
                            sourceFav=carregaSourceFav("3lIwFaE5axA"),
                              textFav=carregaTextFav("3lIwFaE5axA"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("LVS89h3Etco"),
                            tag1="O Amor Chegou à Vizinhança",
                            duracao="22:00",
                            id="LVS89h3Etco",
                            sourceFav=carregaSourceFav("LVS89h3Etco"),
                              textFav=carregaTextFav("LVS89h3Etco"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("EUFkdjR1R9M"),
                            tag1="Uma Brincadeira de Mau Gosto",
                            duracao="22:13",
                            id="EUFkdjR1R9M",
                            sourceFav=carregaSourceFav("EUFkdjR1R9M"),
                              textFav=carregaTextFav("EUFkdjR1R9M"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("d4MXUAFygVc"),
                            tag1="A Casa da Bruxa",
                            duracao="22:34",
                            id="d4MXUAFygVc",
                            sourceFav=carregaSourceFav("d4MXUAFygVc"),
                              textFav=carregaTextFav("d4MXUAFygVc"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("4L84hCIDlIQ"),
                            tag1="Como Treinar um Novo Campeão",
                            duracao="21:55",
                            id="4L84hCIDlIQ",
                            sourceFav=carregaSourceFav("4L84hCIDlIQ"),
                              textFav=carregaTextFav("4L84hCIDlIQ"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("2a3KX8n0f3M"),
                            tag1="Quanto Mais Quente, Pior",
                            duracao="20:42",
                            id="2a3KX8n0f3M",
                            sourceFav=carregaSourceFav("2a3KX8n0f3M"),
                              textFav=carregaTextFav("2a3KX8n0f3M"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("6laVGr4yk6I"),
                            tag1="Os Bombeiros",
                            duracao="20:09",
                            id="6laVGr4yk6I",
                            sourceFav=carregaSourceFav("6laVGr4yk6I"),
                              textFav=carregaTextFav("6laVGr4yk6I"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("okCKl_ZrP28"),
                            tag1="Abre a Torneira",
                            duracao="21:56",
                            id="okCKl_ZrP28",
                            sourceFav=carregaSourceFav("okCKl_ZrP28"),
                              textFav=carregaTextFav("okCKl_ZrP28"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("2KBtKMtI9EA"),
                            tag1="Pintando a Vila",
                            duracao="21:59",
                            id="2KBtKMtI9EA",
                            sourceFav=carregaSourceFav("2KBtKMtI9EA"),
                              textFav=carregaTextFav("2KBtKMtI9EA"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("B9w88ZFwxKA"),
                            tag1="O Desjejum do Chaves",
                            duracao="20:43",
                            id="B9w88ZFwxKA",
                            sourceFav=carregaSourceFav("B9w88ZFwxKA"),
                              textFav=carregaTextFav("B9w88ZFwxKA"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("0SG0OIRlX8Y"),
                            tag1="A Casinha do Chaves",
                            duracao="21:44",
                            id="0SG0OIRlX8Y",
                            sourceFav=carregaSourceFav("0SG0OIRlX8Y"),
                              textFav=carregaTextFav("0SG0OIRlX8Y"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("30u8fUY0Psw"),
                            tag1="Sonâmbulos",
                            duracao="21:57",
                            id="30u8fUY0Psw",
                            sourceFav=carregaSourceFav("30u8fUY0Psw"),
                              textFav=carregaTextFav("30u8fUY0Psw"),
                        },
                        new MyListViewModel
                        {
                            Field1=CarregarImagem("Wh0X7O2abzQ"),
                            tag1="Vamos Todos a Acapulco",
                            duracao="20:29",
                            id="Wh0X7O2abzQ",
                            sourceFav=carregaSourceFav("Wh0X7O2abzQ"),
                              textFav=carregaTextFav("Wh0X7O2abzQ"),
                        }

                  };
                //adiciona os dados ao listBox
                BindData();
            }
                 );
        }
        //2temporada
        private void LoadTestData2Temporada()
        {
            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                myVM = new ObservableCollection<MyListViewModel> 
                  { 
                      new MyListViewModel
                          {
                              id="I3UoihY9XrU",
                              Field1 = CarregarImagem("I3UoihY9XrU"),
                              tag1="O grande prêmio da vizinhança",  
                              duracao="20:10",
                              sourceFav=carregaSourceFav("I3UoihY9XrU"),
                              textFav=carregaTextFav("I3UoihY9XrU"),
                          },
                          new MyListViewModel 
                          { 
                              id="MfAdqTbumLk",
                              Field1 = CarregarImagem("MfAdqTbumLk"),
                              tag1="O Justiceiro Mascarado",
                              duracao="21:59",
                              sourceFav=carregaSourceFav("MfAdqTbumLk"),
                              textFav=carregaTextFav("MfAdqTbumLk"),
                          },
                      new MyListViewModel 
                          { 
                              id="BhrAqrz6N0Y",
                              Field1 =CarregarImagem("BhrAqrz6N0Y"),
                              tag1="As histórias de terror",
                              duracao="20:30",
                              sourceFav=carregaSourceFav("BhrAqrz6N0Y"),
                              textFav=carregaTextFav("BhrAqrz6N0Y"),
                          },
                          new MyListViewModel 
                          { 
                              id="oH_jcd6MXec",
                              Field1 =CarregarImagem("oH_jcd6MXec"),
                              tag1="Como sobem os alimentos",
                              duracao="22:29",
                              sourceFav=carregaSourceFav("oH_jcd6MXec"),
                              textFav=carregaTextFav("oH_jcd6MXec"),
                          },
                        new MyListViewModel
                        {
                            id="hdTIXmbQRXA",
                              Field1 =CarregarImagem("hdTIXmbQRXA"),
                              tag1="O dinheiro perdido",
                              duracao="22:27",
                              sourceFav=carregaSourceFav("hdTIXmbQRXA"),
                              textFav=carregaTextFav("hdTIXmbQRXA"),
                        },
                        new MyListViewModel
                        {
                            id="PRXx4WWJu-I",
                              Field1 =CarregarImagem("PRXx4WWJu-I"),
                              tag1="Vamos cuidar da água",
                              duracao="22:30",
                              sourceFav=carregaSourceFav("PRXx4WWJu-I"),
                              textFav=carregaTextFav("PRXx4WWJu-I"),
                        },
                        new MyListViewModel
                        {
                            id="tYdHuvGmip4",
                              Field1 =CarregarImagem("tYdHuvGmip4"),
                              tag1="Seu Madruga apaixonado",
                              duracao="21:30",
                              sourceFav=carregaSourceFav("tYdHuvGmip4"),
                              textFav=carregaTextFav("tYdHuvGmip4"),
                        },
                        new MyListViewModel
                        {
                            id="cTwXabC7HAQ",
                              Field1 =CarregarImagem("cTwXabC7HAQ"),
                              tag1="Amando os inimigos",
                              duracao="21:56",
                              sourceFav=carregaSourceFav("cTwXabC7HAQ"),
                              textFav=carregaTextFav("cTwXabC7HAQ"),
                        },
                        new MyListViewModel
                        {
                            id="HSLsCgQRhu0",
                              Field1 =CarregarImagem("HSLsCgQRhu0"),
                              tag1="Os presentes de Natal",
                              duracao="22:26",
                              sourceFav=carregaSourceFav("HSLsCgQRhu0"),
                              textFav=carregaTextFav("HSLsCgQRhu0"),
                        },
                        new MyListViewModel
                        {
                            id="kBi_uyZvlYo",
                              Field1 =CarregarImagem("kBi_uyZvlYo"),
                              tag1="O homem invisível",
                              duracao="20:26",
                              sourceFav=carregaSourceFav("kBi_uyZvlYo"),
                              textFav=carregaTextFav("kBi_uyZvlYo"),
                        },
                        new MyListViewModel
                        {
                            id="jWVaCzwXeqg",
                              Field1 =CarregarImagem("jWVaCzwXeqg"),
                              tag1="Refrescos do Chaves",
                              duracao="20:11",
                              sourceFav=carregaSourceFav("jWVaCzwXeqg"),
                              textFav=carregaTextFav("jWVaCzwXeqg"),
                        },
                        new MyListViewModel
                        {
                            id="t5rKzEDOZF4",
                              Field1 =CarregarImagem("t5rKzEDOZF4"),
                              tag1="O leiteiro",
                              duracao="21:54",
                              sourceFav=carregaSourceFav("t5rKzEDOZF4"),
                              textFav=carregaTextFav("t5rKzEDOZF4"),
                        },
                        new MyListViewModel
                        {
                            id="i-t7ushz-k0",
                              Field1 =CarregarImagem("i-t7ushz-k0"),
                              tag1="Vizinhança em guerra",
                              duracao="20:41",
                              sourceFav=carregaSourceFav("i-t7ushz-k0"),
                              textFav=carregaTextFav("i-t7ushz-k0"),
                        },
                        new MyListViewModel
                        {
                            id="HtqKY_NE6m4",
                              Field1 =CarregarImagem("HtqKY_NE6m4"),
                              tag1="Procura-se",
                              duracao="20:12",
                              sourceFav=carregaSourceFav("HtqKY_NE6m4"),
                              textFav=carregaTextFav("HtqKY_NE6m4"),
                        },
                        new MyListViewModel
                        {
                            id="6xQaF4M_r9s",
                              Field1 =CarregarImagem("6xQaF4M_r9s"),
                              tag1="Chaves, o cantor",
                              duracao="20:30",
                              sourceFav=carregaSourceFav("6xQaF4M_r9s"),
                              textFav=carregaTextFav("6xQaF4M_r9s"),
                        },
                        new MyListViewModel
                        {
                            id="82JaRcI_7KQ",
                              Field1 =CarregarImagem("82JaRcI_7KQ"),
                              tag1="Olha o pneu, Sr. Barriga!",
                              duracao="20:44",
                              sourceFav=carregaSourceFav("82JaRcI_7KQ"),
                              textFav=carregaTextFav("82JaRcI_7KQ"),
                        },
                        new MyListViewModel
                        {
                            id="1wK29cEpnNs",
                              Field1 =CarregarImagem("1wK29cEpnNs"),
                              tag1="Invasão extraterrestre",
                              duracao="21:32",
                              sourceFav=carregaSourceFav("1wK29cEpnNs"),
                              textFav=carregaTextFav("1wK29cEpnNs"),
                        },
                        new MyListViewModel
                        {
                            id="FR2ClFOJfrY",
                              Field1 =CarregarImagem("FR2ClFOJfrY"),
                              tag1="O acampamento",
                              duracao="21:14",
                              sourceFav=carregaSourceFav("FR2ClFOJfrY"),
                              textFav=carregaTextFav("FR2ClFOJfrY"),
                        },
                        new MyListViewModel
                        {
                            id="WXOaBKyVp-8",
                              Field1 =CarregarImagem("WXOaBKyVp-8"),
                              tag1="Os dentes de leite",
                              duracao="20:09",
                              sourceFav=carregaSourceFav("WXOaBKyVp-8"),
                              textFav=carregaTextFav("WXOaBKyVp-8"),
                        },
                        new MyListViewModel
                        {
                            id="E8M510V6DNw",
                              Field1 =CarregarImagem("E8M510V6DNw"),
                              tag1="A namorada do Chaves",
                              duracao="22:08",
                              sourceFav=carregaSourceFav("E8M510V6DNw"),
                              textFav=carregaTextFav("E8M510V6DNw"),
                        },
                        new MyListViewModel
                        {
                            id="mD0jKZFM4pg",
                              Field1 =CarregarImagem("mD0jKZFM4pg"),
                              tag1="Um bebê na vila",
                              duracao="22:38",
                              sourceFav=carregaSourceFav("mD0jKZFM4pg"),
                              textFav=carregaTextFav("mD0jKZFM4pg"),
                        },
                        new MyListViewModel
                        {
                            id="3-oERnWZNqI",
                              Field1 =CarregarImagem("3-oERnWZNqI"),
                              tag1="Vamos ao circo",
                              duracao="20:08",
                              sourceFav=carregaSourceFav("3-oERnWZNqI"),
                              textFav=carregaTextFav("3-oERnWZNqI"),
                        },
                        new MyListViewModel
                        {
                            id="5H081cfjjQg",
                              Field1 =CarregarImagem("5H081cfjjQg"),
                              tag1="As olimpíadas",
                              duracao="21:52",
                              sourceFav=carregaSourceFav("5H081cfjjQg"),
                              textFav=carregaTextFav("5H081cfjjQg"),
                        },
                        new MyListViewModel
                        {
                            id="HCn5j2kBW3g",
                              Field1 =CarregarImagem("HCn5j2kBW3g"),
                              tag1="Brinquedos de papel",
                              duracao="21:52",
                              sourceFav=carregaSourceFav("HCn5j2kBW3g"),
                              textFav=carregaTextFav("HCn5j2kBW3g"),
                        },
                        new MyListViewModel
                        {
                            id="0Sv9VxMJW3M",
                              Field1 =CarregarImagem("0Sv9VxMJW3M"),
                              tag1="O verdadeiro espírito de Natal I",
                              duracao="22:04",
                              sourceFav=carregaSourceFav("0Sv9VxMJW3M"),
                              textFav=carregaTextFav("0Sv9VxMJW3M"),
                        },
                        new MyListViewModel
                        {
                            id="Yjxewd8c-08",
                              Field1 =CarregarImagem("Yjxewd8c-08"),
                              tag1="Os piratas",
                              duracao="21:38",
                              sourceFav=carregaSourceFav("Yjxewd8c-08"),
                              textFav=carregaTextFav("Yjxewd8c-08"),
                        }

                  };
                //adiciona os dados ao listBox
                BindData();
            }
                 );
        }
        //3temporada
        private void LoadTestData3Temporada()
        {
            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                myVM = new ObservableCollection<MyListViewModel> 
                  { 
                      new MyListViewModel
                          {
                              
                              id="0buMabOB0Xg",
                              Field1 = CarregarImagem("0buMabOB0Xg"),
                              tag1="Tudo por um bolo",  
                              duracao="21:35",
                              sourceFav=carregaSourceFav("0buMabOB0Xg"),
                              textFav=carregaTextFav("0buMabOB0Xg"),
                          },
                          new MyListViewModel 
                          { 
                              id="PMOMOs-8wa8",
                              Field1 = CarregarImagem("PMOMOs-8wa8"),
                              tag1="Visita ao zoológico",  
                              duracao="21:29",
                              sourceFav=carregaSourceFav("PMOMOs-8wa8"),
                              textFav=carregaTextFav("PMOMOs-8wa8"),
                          },
                      new MyListViewModel 
                          { 
                              id="3A9MhaE6GDo",
                              Field1 = CarregarImagem("3A9MhaE6GDo"),
                              tag1=" A partida de futebol",  
                              duracao="21:33",
                              sourceFav=carregaSourceFav("3A9MhaE6GDo"),
                              textFav=carregaTextFav("3A9MhaE6GDo"),
                          },
                          new MyListViewModel 
                          { 
                              id="d6HvUGc0cUE",
                              Field1 = CarregarImagem("d6HvUGc0cUE"),
                              tag1="Como num filme",  
                              duracao="20:21",
                              sourceFav=carregaSourceFav("d6HvUGc0cUE"),
                              textFav=carregaTextFav("d6HvUGc0cUE"),
                          },
                        new MyListViewModel
                        {
                            id="Zx2VQDv0HgM",
                              Field1 = CarregarImagem("Zx2VQDv0HgM"),
                              tag1="Chaves e o lobo",  
                              duracao="21:28",
                              sourceFav=carregaSourceFav("Zx2VQDv0HgM"),
                              textFav=carregaTextFav("Zx2VQDv0HgM"),
                        },
                        new MyListViewModel
                        {
                            id="Y-fwd5ndtvE",
                              Field1 = CarregarImagem("Y-fwd5ndtvE"),
                              tag1="No Velho Oeste",  
                              duracao="21:24",
                              sourceFav=carregaSourceFav("Y-fwd5ndtvE"),
                              textFav=carregaTextFav("Y-fwd5ndtvE"),
                        },
                        new MyListViewModel
                        {
                            id="4xBSLIyGi_E",
                              Field1 = CarregarImagem("4xBSLIyGi_E"),
                              tag1="Cuidado com as rãs",  
                              duracao="22:32",
                              sourceFav=carregaSourceFav("4xBSLIyGi_E"),
                              textFav=carregaTextFav("4xBSLIyGi_E"),
                        },
                        new MyListViewModel
                        {
                            id="rYbUZWy6iOQ",
                              Field1 = CarregarImagem("rYbUZWy6iOQ"),
                              tag1="Teatro na vila",  
                              duracao="21:18",
                              sourceFav=carregaSourceFav("rYbUZWy6iOQ"),
                              textFav=carregaTextFav("rYbUZWy6iOQ"),
                        },
                        new MyListViewModel
                        {
                            id="-MR8C13ITWk",
                              Field1 = CarregarImagem("-MR8C13ITWk"),
                              tag1="Duas mosqueteiras e o Chaves",  
                              duracao="21:25",
                              sourceFav=carregaSourceFav("-MR8C13ITWk"),
                              textFav=carregaTextFav("-MR8C13ITWk"),
                        },
                        new MyListViewModel
                        {
                            id="EAtEVpiRKs4",
                              Field1 = CarregarImagem("EAtEVpiRKs4"),
                              tag1="Um dia de sorte",  
                              duracao="20:18",
                              sourceFav=carregaSourceFav("EAtEVpiRKs4"),
                              textFav=carregaTextFav("EAtEVpiRKs4"),
                        },
                        new MyListViewModel
                        {
                            id="0RmQzf0U7XY",
                              Field1 = CarregarImagem("0RmQzf0U7XY"),
                              tag1="O parque de diversões",  
                              duracao="20:27",
                              sourceFav=carregaSourceFav("0RmQzf0U7XY"),
                              textFav=carregaTextFav("0RmQzf0U7XY"),
                        },
                        new MyListViewModel
                        {
                            id="LvrHyONt_uc",
                              Field1 = CarregarImagem("LvrHyONt_uc"),
                              tag1="O valor da amizade",  
                              duracao="21:42",
                              sourceFav=carregaSourceFav("LvrHyONt_uc"),
                              textFav=carregaTextFav("LvrHyONt_uc"),
                        },
                        new MyListViewModel
                        {
                            id="xCW-UuNH2Ng",
                              Field1 = CarregarImagem("xCW-UuNH2Ng"),
                              tag1="A noite dos espantos",  
                              duracao="21:43",
                              sourceFav=carregaSourceFav("xCW-UuNH2Ng"),
                              textFav=carregaTextFav("xCW-UuNH2Ng"),
                        },
                        new MyListViewModel
                        {
                            id="pDhmdZVvrKs",
                              Field1 = CarregarImagem("pDhmdZVvrKs"),
                              tag1="Caído do céu",  
                              duracao="21:45",
                              sourceFav=carregaSourceFav("pDhmdZVvrKs"),
                              textFav=carregaTextFav("pDhmdZVvrKs"),
                        },
                        new MyListViewModel
                        {
                            id="bDCKQ15UM4w",
                              Field1 = CarregarImagem("bDCKQ15UM4w"),
                              tag1="O Festival do Meio Ambiente",  
                              duracao="21:31",
                              sourceFav=carregaSourceFav("bDCKQ15UM4w"),
                              textFav=carregaTextFav("bDCKQ15UM4w"),
                        },
                        new MyListViewModel
                        {
                            id="XAqWJc8k0bg",
                              Field1 = CarregarImagem("XAqWJc8k0bg"),
                              tag1="Um dia na televisão",  
                              duracao="21:34",
                              sourceFav=carregaSourceFav("XAqWJc8k0bg"),
                              textFav=carregaTextFav("XAqWJc8k0bg"),
                        },
                        new MyListViewModel
                        {
                            id="Lz-iA7EtGr4",
                              Field1 = CarregarImagem("Lz-iA7EtGr4"),
                              tag1="Um bom recado",  
                              duracao="22:01",
                              sourceFav=carregaSourceFav("Lz-iA7EtGr4"),
                              textFav=carregaTextFav("Lz-iA7EtGr4"),
                        },
                        new MyListViewModel
                        {
                           id="ag3wjnfGTyY",
                              Field1 = CarregarImagem("ag3wjnfGTyY"),
                              tag1="O entregador de pizzas",  
                              duracao="21:37",
                              sourceFav=carregaSourceFav("ag3wjnfGTyY"),
                              textFav=carregaTextFav("ag3wjnfGTyY"),
                        },
                        new MyListViewModel
                        {
                            id="WtiLvjGUzAA",
                              Field1 = CarregarImagem("WtiLvjGUzAA"),
                              tag1="O ataque dos insetos",  
                              duracao="21:29",
                              sourceFav=carregaSourceFav("WtiLvjGUzAA"),
                              textFav=carregaTextFav("WtiLvjGUzAA"),
                        },
                        new MyListViewModel
                        {
                            id="KWrEmvXEjDY",
                              Field1 = CarregarImagem("KWrEmvXEjDY"),
                              tag1="Pintando o sete",  
                              duracao="21:29",
                              sourceFav=carregaSourceFav("KWrEmvXEjDY"),
                              textFav=carregaTextFav("KWrEmvXEjDY"),
                        },
                        new MyListViewModel
                        {
                            id="uoMXyS_7iK4",
                              Field1 = CarregarImagem("uoMXyS_7iK4"),
                              tag1="Visita ao museu",  
                              duracao="20:35",
                              sourceFav=carregaSourceFav("uoMXyS_7iK4"),
                              textFav=carregaTextFav("uoMXyS_7iK4"),
                        },
                        new MyListViewModel
                        {
                            id="RUVquToGKQE",
                              Field1 = CarregarImagem("RUVquToGKQE"),
                              tag1="Não se vá, Nhonho!",  
                              duracao="21:35",
                              sourceFav=carregaSourceFav("RUVquToGKQE"),
                              textFav=carregaTextFav("RUVquToGKQE"),
                        },
                        new MyListViewModel
                        {
                            id="sQsAxtg4rbY",
                              Field1 = CarregarImagem("sQsAxtg4rbY"),
                              tag1="Inverno na vila",  
                              duracao="20:04",
                              sourceFav=carregaSourceFav("sQsAxtg4rbY"),
                              textFav=carregaTextFav("sQsAxtg4rbY"),
                        },
                        new MyListViewModel
                        {
                           id="mN26M-JoyE8",
                              Field1 = CarregarImagem("mN26M-JoyE8"),
                              tag1="A casinha da árvore",  
                              duracao="20:13",
                              sourceFav=carregaSourceFav("mN26M-JoyE8"),
                              textFav=carregaTextFav("mN26M-JoyE8"),
                        },
                        new MyListViewModel
                        {
                            id="LN651fJKgzg",
                              Field1 = CarregarImagem("LN651fJKgzg"),
                              tag1="A máquina do tempo I",  
                              duracao="21:21",
                              sourceFav=carregaSourceFav("LN651fJKgzg"),
                              textFav=carregaTextFav("LN651fJKgzg"),
                        },
                        new MyListViewModel
                        {
                            id="z9K-GT_t7EU",
                              Field1 = CarregarImagem("z9K-GT_t7EU"),
                              tag1="A máquina do tempo II",  
                              duracao="21:32",
                              sourceFav=carregaSourceFav("z9K-GT_t7EU"),
                              textFav=carregaTextFav("z9K-GT_t7EU"),
                        }

                  };
                //adiciona os dados ao listBox
                BindData();
            }
                 );
        }
        //4temporada
        private void LoadTestData4Temporada()
        {
            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                myVM = new ObservableCollection<MyListViewModel> 
                  { 
                      new MyListViewModel
                          {
                            id="tI76968aNfE",
                              Field1 = CarregarImagem("tI76968aNfE"),
                              tag1="A planta do Chaves",  
                              duracao="21:47",
                              sourceFav=carregaSourceFav("tI76968aNfE"),
                              textFav=carregaTextFav("tI76968aNfE"),
                          },
                          new MyListViewModel 
                          { 
                             id="bwf0EWmQ1ZU",
                              Field1 = CarregarImagem("bwf0EWmQ1ZU"),
                              tag1="Uma montanha Altississississíma",  
                              duracao="21:30",
                              sourceFav=carregaSourceFav("bwf0EWmQ1ZU"),
                              textFav=carregaTextFav("bwf0EWmQ1ZU"),
                          },
                      new MyListViewModel 
                          { 
                              id="Kmmw7OhP2Iw",
                              Field1 = CarregarImagem("Kmmw7OhP2Iw"),
                              tag1="Uma aventura das grandes",  
                              duracao="21:57",
                              sourceFav=carregaSourceFav("Kmmw7OhP2Iw"),
                              textFav=carregaTextFav("Kmmw7OhP2Iw"),
                          },
                          new MyListViewModel 
                          { 
                              id="IPyKNi3ZXhM",
                              Field1 = CarregarImagem("IPyKNi3ZXhM"),
                              tag1="Uma vila de lendas",  
                              duracao="21:27",
                              sourceFav=carregaSourceFav("IPyKNi3ZXhM"),
                              textFav=carregaTextFav("IPyKNi3ZXhM"),
                          },
                        new MyListViewModel
                        {
                            id="Ju-iU6aLu6I",
                              Field1 = CarregarImagem("Ju-iU6aLu6I"),
                              tag1="Borbulhas e mais borbulhas",  
                              duracao="21:21",
                              sourceFav=carregaSourceFav("Ju-iU6aLu6I"),
                              textFav=carregaTextFav("Ju-iU6aLu6I"),
                        },
                        new MyListViewModel
                        {
                            id="RwK39WMGQ8g",
                              Field1 = CarregarImagem("RwK39WMGQ8g"),
                              tag1="A arte mágica",  
                              duracao="21:09",
                              sourceFav=carregaSourceFav("RwK39WMGQ8g"),
                              textFav=carregaTextFav("RwK39WMGQ8g"),
                        },
                        new MyListViewModel
                        {
                            id="7cByyQ8IeYU",
                              Field1 = CarregarImagem("7cByyQ8IeYU"),
                              tag1="O conselheiro sentimental",  
                              duracao="21:39",
                              sourceFav=carregaSourceFav("7cByyQ8IeYU"),
                              textFav=carregaTextFav("7cByyQ8IeYU"),
                        },
                        new MyListViewModel
                        {
                            id="rtHC9-MP3e4",
                              Field1 = CarregarImagem("rtHC9-MP3e4"),
                              tag1="Aventura Submarina",  
                              duracao="21:24",
                              sourceFav=carregaSourceFav("rtHC9-MP3e4"),
                              textFav=carregaTextFav("rtHC9-MP3e4"),
                        },
                        new MyListViewModel
                        {
                            id="kPf-XRRbcP0",
                              Field1 = CarregarImagem("kPf-XRRbcP0"),
                              tag1="A venda da Vila",  
                              duracao="21:26",
                              sourceFav=carregaSourceFav("kPf-XRRbcP0"),
                              textFav=carregaTextFav("kPf-XRRbcP0"),
                        },
                        new MyListViewModel
                        {
                            id="mY8HVwYvGHQ",
                              Field1 = CarregarImagem("mY8HVwYvGHQ"),
                              tag1="A venda da Vila 2",  
                              duracao="21:45",
                              sourceFav=carregaSourceFav("mY8HVwYvGHQ"),
                              textFav=carregaTextFav("mY8HVwYvGHQ"),
                        },
                        new MyListViewModel
                        {
                            id="G_8wEHZAB-E",
                              Field1 = CarregarImagem("G_8wEHZAB-E"),
                              tag1="Chaves, o cientista",  
                              duracao="21:40",
                              sourceFav=carregaSourceFav("G_8wEHZAB-E"),
                              textFav=carregaTextFav("G_8wEHZAB-E"),
                        },
                        new MyListViewModel
                        {
                            id="g2TI7X0LvCM",
                              Field1 = CarregarImagem("g2TI7X0LvCM"),
                              tag1="Seu Madruga popstar",  
                              duracao="21:26",
                              sourceFav=carregaSourceFav("g2TI7X0LvCM"),
                              textFav=carregaTextFav("g2TI7X0LvCM"),
                        },
                        new MyListViewModel
                        {
                            id="_TufHcthCuA",
                              Field1 = CarregarImagem("_TufHcthCuA"),
                              tag1="Uma História na Pré-História",  
                              duracao="20:59",
                              sourceFav=carregaSourceFav("_TufHcthCuA"),
                              textFav=carregaTextFav("_TufHcthCuA"),
                        },
                        new MyListViewModel
                        {
                            id="n4zIQ_fBs0U",
                              Field1 = CarregarImagem("n4zIQ_fBs0U"),
                              tag1="Todos em forma",  
                              duracao="21:31",
                              sourceFav=carregaSourceFav("n4zIQ_fBs0U"),
                              textFav=carregaTextFav("n4zIQ_fBs0U"),
                        },
                        new MyListViewModel
                        {
                            id="yamHJ45YkaY",
                              Field1 = CarregarImagem("yamHJ45YkaY"),
                              tag1="O ovo fresco",  
                              duracao="21:20",
                              sourceFav=carregaSourceFav("yamHJ45YkaY"),
                              textFav=carregaTextFav("yamHJ45YkaY"),
                        },
                        new MyListViewModel
                        {
                            id="IUSyc2KGZvU",
                              Field1 = CarregarImagem("IUSyc2KGZvU"),
                              tag1="Artes Marciais",  
                              duracao="20:19",
                              sourceFav=carregaSourceFav("IUSyc2KGZvU"),
                              textFav=carregaTextFav("IUSyc2KGZvU"),
                        },
                        new MyListViewModel
                        {
                            id="h7fj_FtH8vQ",
                              Field1 = CarregarImagem("h7fj_FtH8vQ"),
                              tag1="As goteiras",  
                              duracao="20:39",
                              sourceFav=carregaSourceFav("h7fj_FtH8vQ"),
                              textFav=carregaTextFav("h7fj_FtH8vQ"),
                        },
                        new MyListViewModel
                        {
                            id="FCW28sJuEN8",
                              Field1 = CarregarImagem("FCW28sJuEN8"),
                              tag1="Viagem espacial",  
                              duracao="20:42",
                              sourceFav=carregaSourceFav("FCW28sJuEN8"),
                              textFav=carregaTextFav("FCW28sJuEN8"),
                        },
                        new MyListViewModel
                        {
                            id="YssAuEYNflI",
                              Field1 = CarregarImagem("YssAuEYNflI"),
                              tag1="A Serenata",  
                              duracao="20:30",
                              sourceFav=carregaSourceFav("YssAuEYNflI"),
                              textFav=carregaTextFav("YssAuEYNflI"),
                        },
                        new MyListViewModel
                        {
                            id="ZTkCUj6K3qk",
                              Field1 = CarregarImagem("ZTkCUj6K3qk"),
                              tag1="A granja da vila",  
                              duracao="20:55",
                              sourceFav=carregaSourceFav("ZTkCUj6K3qk"),
                              textFav=carregaTextFav("ZTkCUj6K3qk"),
                        },
                        new MyListViewModel
                        {
                            id="4hLzGFGo1HI",
                              Field1 = CarregarImagem("4hLzGFGo1HI"),
                              tag1="O Táxi Do Chaves",  
                              duracao="21:43",
                              sourceFav=carregaSourceFav("4hLzGFGo1HI"),
                              textFav=carregaTextFav("4hLzGFGo1HI"),
                        },
                        new MyListViewModel
                        {
                           id="uw4C-Xckhw4",
                              Field1 = CarregarImagem("uw4C-Xckhw4"),
                              tag1="A viagem de metrô",  
                              duracao="20:28",
                              sourceFav=carregaSourceFav("uw4C-Xckhw4"),
                              textFav=carregaTextFav("uw4C-Xckhw4"),
                        },
                        new MyListViewModel
                        {
                            id="HB-wD_VnEdU",
                              Field1 = CarregarImagem("HB-wD_VnEdU"),
                              tag1="ESPECIAL - Que Bonito Natal - LEGENDADO PT-BR",  
                              duracao="43:10",
                              sourceFav=carregaSourceFav("HB-wD_VnEdU"),
                              textFav=carregaTextFav("HB-wD_VnEdU"),
                        }
                  };
                //adiciona os dados ao listBox
                BindData();
            }
                 );
        }
        //5temporada
        private void LoadTestData5Temporada()
        {
            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                myVM = new ObservableCollection<MyListViewModel> 
                  { 
                      new MyListViewModel
                          {
                             id="lMGKU1eWSQs",
                              Field1 = CarregarImagem("lMGKU1eWSQs"),
                              tag1="Histórias de Vizinhança",  
                              duracao="20:25",
                              sourceFav=carregaSourceFav("lMGKU1eWSQs"),
                              textFav=carregaTextFav("lMGKU1eWSQs"),
                          },
                          new MyListViewModel 
                          { 
                              id="HD5W-gBcm_0",
                              Field1 = CarregarImagem("HD5W-gBcm_0"),
                              tag1="O Amuleto do Chaves",  
                              duracao="20:37",
                              sourceFav=carregaSourceFav("HD5W-gBcm_0"),
                              textFav=carregaTextFav("HD5W-gBcm_0"),
                          },
                      new MyListViewModel 
                          { 
                              id="C-ibPkxMAnk",
                              Field1 = CarregarImagem("C-ibPkxMAnk"),
                              tag1="Quem Toca o Piano ?",  
                              duracao="20:36",
                              sourceFav=carregaSourceFav("C-ibPkxMAnk"),
                              textFav=carregaTextFav("C-ibPkxMAnk"),
                          },
                          new MyListViewModel 
                          { 
                             id="uCVgO4S0CHE",
                              Field1 = CarregarImagem("uCVgO4S0CHE"),
                              tag1="O Strike do Chaves",  
                              duracao="20:15",
                              sourceFav=carregaSourceFav("uCVgO4S0CHE"),
                              textFav=carregaTextFav("uCVgO4S0CHE"),
                          },
                        new MyListViewModel
                        {
                            id="9UCVL2abPO4",
                              Field1 = CarregarImagem("9UCVL2abPO4"),
                              tag1="Um Ataque de Soluço",  
                              duracao="20:16",
                              sourceFav=carregaSourceFav("9UCVL2abPO4"),
                              textFav=carregaTextFav("9UCVL2abPO4"),
                        },
                        new MyListViewModel
                        {
                            id="vc0CV_ZMrgA",
                              Field1 = CarregarImagem("vc0CV_ZMrgA"),
                              tag1="Chaves no Egito",  
                              duracao="20:05",
                              sourceFav=carregaSourceFav("vc0CV_ZMrgA"),
                              textFav=carregaTextFav("vc0CV_ZMrgA"),
                        },
                        new MyListViewModel
                        {
                            id="ltyOocOyjlk",
                              Field1 = CarregarImagem("ltyOocOyjlk"),
                              tag1="Seu Madruga Cabeleireiro",  
                              duracao="20:15",
                              sourceFav=carregaSourceFav("ltyOocOyjlk"),
                              textFav=carregaTextFav("ltyOocOyjlk"),
                        },
                        new MyListViewModel
                        {
                            id="BiDTeSfzKjM",
                              Field1 = CarregarImagem("BiDTeSfzKjM"),
                              tag1=" As Festas de Tangamandápio",  
                              duracao="20:46",
                              sourceFav=carregaSourceFav("BiDTeSfzKjM"),
                              textFav=carregaTextFav("BiDTeSfzKjM"),
                        },
                        new MyListViewModel
                        {
                            id="DXMMdlhr89M",
                              Field1 = CarregarImagem("DXMMdlhr89M"),
                              tag1="Rádio da Vizinhança",  
                              duracao="20:16",
                              sourceFav=carregaSourceFav("DXMMdlhr89M"),
                              textFav=carregaTextFav("DXMMdlhr89M"),
                        },
                        new MyListViewModel
                        {
                            id="LW9G3aeFsp4",
                              Field1 = CarregarImagem("LW9G3aeFsp4"),
                              tag1="O voo do Chaves",  
                              duracao="20:43",
                              sourceFav=carregaSourceFav("LW9G3aeFsp4"),
                              textFav=carregaTextFav("LW9G3aeFsp4"),
                        },
                        new MyListViewModel
                        {
                            id="m_Un2m40eHs",
                              Field1 = CarregarImagem("m_Un2m40eHs"),
                              tag1="Os empregos do Chaves",  
                              duracao="20:26",
                              sourceFav=carregaSourceFav("m_Un2m40eHs"),
                              textFav=carregaTextFav("m_Un2m40eHs"),
                        },
                        new MyListViewModel
                        {
                            id="aqtDifNpO7Q",
                              Field1 = CarregarImagem("aqtDifNpO7Q"),
                              tag1="Un amigo robot - IDIOMA ESPANHOL",  
                              duracao="22:32",
                              sourceFav=carregaSourceFav("aqtDifNpO7Q"),
                              textFav=carregaTextFav("aqtDifNpO7Q"),
                        },
                        new MyListViewModel
                        {
                            id="J8Jt8fEWHxk",
                              Field1 = CarregarImagem("J8Jt8fEWHxk"),
                              tag1="Vamos ao estádio",  
                              duracao="20:17",
                              sourceFav=carregaSourceFav("J8Jt8fEWHxk"),
                              textFav=carregaTextFav("J8Jt8fEWHxk"),
                        }

                  };
                //adiciona os dados ao listBox
                BindData();
            }
                 );
        }
        //adiciona ao listbox
        private void BindData()
        {
            listData.ItemsSource = myVM;
        }  
        
        private string CarregarImagem(string idVideo)
        {
            string urlCompleta="";
            urlCompleta = "http://i1.ytimg.com/vi/" + idVideo +"/0.jpg";
            return urlCompleta;
        }

        private void Grid_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                string link = (string)((Grid)sender).Tag.ToString();
                //string destino = "/videoPage.xaml?nome=" + link + "&temporada="+nome;
                //this.NavigationService.Navigate(new Uri(destino, UriKind.Relative));
                playVideo(link);
            }
            catch
            {

            }
        }

        private void playVideo(string id)
        {
            try
            {
                
                YouTube.Play(id, true, YouTubeQuality.Quality480P, x =>
                {
                    if (x != null)
                        MessageBox.Show(x.Message);
                });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            if (YouTube.CancelPlay()) // used to abort current youtube download
                e.Cancel = true;
            else
            {
                // your code here
            }
            base.OnBackKeyPress(e);
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (YouTube.CancelPlay()) // used to abort current youtube download
                e.Cancel = true;
            else
            {
                // your code here
            }
            base.OnBackKeyPress(e);
        }

        private void imgFav_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string id = (string)((Image)sender).Tag.ToString();
            salvaFavorito(id);
            atualizaLista(PageTitle.Text);
        }

        private void salvaFavorito(string idVideo)
        {
            if (iso.Contains(idVideo))
            {
                bool aux=false;
                iso.TryGetValue<bool>(idVideo, out aux);
                if (aux)
                    iso[idVideo] = false;
                else
                    iso[idVideo] = true;
            }
            else
            {
                iso.Add(idVideo, true);
            }
        }

        private bool carregaFavorito(string idVideo)
        {
            bool retorno=false;
            if (iso.TryGetValue<bool>(idVideo, out retorno))
            {}
            return retorno;
        }

        private string carregaSourceFav(string idVideo)
        {
            string retorno = "Images/star3.png";
            if (carregaFavorito(idVideo))
            {
                retorno = "Images/star2.png";
            }
            return retorno;
        }

        private string carregaTextFav(string idVideo)
        {
            string retorno = "Marcar como Favorito";
            if (carregaFavorito(idVideo))
            {
                retorno = "Marcado como Favorito";
            }
            return retorno;
        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                string link = (string)((Image)sender).Tag.ToString();
                //string destino = "/videoPage.xaml?nome=" + link + "&temporada="+nome;
                //this.NavigationService.Navigate(new Uri(destino, UriKind.Relative));
                playVideo(link);
            }
            catch
            {

            }
        }
    }

    public class MyListViewModel
    {
        public string Field1 { get; set; }

        public string tag1 { get; set; }

        public string duracao { get; set; }

        public string id { get; set; }

        public string sourceFav { get; set; }

        public string textFav { get; set; }
    } 
}