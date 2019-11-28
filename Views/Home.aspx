<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Clutch_Pim.Views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <title>Clutch Kinetcs</title>
      
   
    <link href="../Scripts/Css/bootstrap.min.css" rel="stylesheet" />

    
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css">
    <link href='https://fonts.googleapis.com/css?family=Kaushan+Script' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Droid+Serif:400,700,400italic,700italic' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700' rel='stylesheet' type='text/css'>

    
    <link href="../Scripts/Css/StyleSheet.min.css" rel="stylesheet" />
  </head>

  <body id="page-top">

    <!-- NavBar -->
    <nav class="navbar navbar-expand-lg navbar-dark fixed-top" id="mainNav">
      <div class="container">
         <!--<img class="container-fluid" src="img/menu/logo1.png" />-->
        <a class="navbar-brand js-scroll-trigger" href="#page-top" >Clutch Kinetcs</a>
        <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
          
          <i class="fas fa-bars"></i>
        </button>
        <div class="collapse navbar-collapse" id="navbarResponsive">
          <ul class="navbar-nav text-uppercase ml-auto">
            <li class="nav-item">
              <a class="nav-link js-scroll-trigger" href="#servicos">Serviços</a>
            </li>
            <li class="nav-item">
              <a class="nav-link js-scroll-trigger" href="#veiculo">Veículos</a>
            </li>
            <li class="nav-item">
              <a class="nav-link js-scroll-trigger" href="#empresa">Empresa</a>
            </li>
            <li class="nav-item">
              <a class="nav-link js-scroll-trigger" href="#contato">Contato</a>
            </li>
              <li class="nav-item">
              <a class="nav-link js-scroll-trigger" href="#login">Login</a>
            </li>
          </ul>
        </div>
      </div>
    </nav>

    <!-- Header -->
    <header class="masthead">
      <div class="container">
        <div class="intro-text">
          <div class="intro-lead-in">Bem vindos a Clutch Kinetcs!</div>
          <div class="intro-heading text-uppercase">Prazer em conhece-lo</div>
          <a class="btn btn-primary btn-xl text-uppercase js-scroll-trigger" href="#services">Conte-me mais</a>
        </div>
      </div>
    </header>

    <!-- Serviços -->
    <section id="servicos">
      <div class="container">
        <div class="row">
          <div class="col-lg-12 text-center">
            <h2 class="section-heading text-uppercase">Serviços</h2>
            <h3 class="section-subheading text-muted">Texto a definir</h3>
          </div>
        </div>
        <div class="row text-center">
          <div class="col-md-4">
            <span class="fa-stack fa-4x">
              <i class="fas fa-circle fa-stack-2x text-primary"></i>
              <i class="fas fa-shopping-cart fa-stack-1x fa-inverse"></i>
            </span>
            <h4 class="service-heading">Gestão de Frotas</h4>
            <p class="text-muted">Texto a definir</p>
          </div>
          <div class="col-md-4">
            <span class="fa-stack fa-4x">
              <i class="fas fa-circle fa-stack-2x text-primary"></i>
              <i class="fas fa-laptop fa-stack-1x fa-inverse"></i>
            </span>
            <h4 class="service-heading">Locação de Veículos</h4>
            <p class="text-muted">Texto a definir</p>
          </div>
          
        </div>
      </div>
    </section>

    <!-- Veiculos Grid -->
    <section class="bg-light" id="veiculo">
      <div class="container">
        <div class="row">
          <div class="col-lg-12 text-center">
            <h2 class="section-heading text-uppercase">Veículos</h2>
            <h3 class="section-subheading text-muted">O que a de mais novo e tecnologico para sua empresa!</h3>
          </div>
        </div>
        <div class="row">
          <div class="col-md-4 col-sm-6 portfolio-item">
            <a class="portfolio-link" data-toggle="modal" href="#portfolioModal1">
              <div class="portfolio-hover">
                <div class="portfolio-hover-content">
                  <i class="fas fa-plus fa-3x"></i>
                </div>
              </div>
              <img class="img-fluid" src="../img/Veiculos/argo-veiculos-home.png" alt="">
            </a>
            <div class="portfolio-caption">
              <h4>Fiat Argo</h4>
              <p class="text-muted">Texto a definir</p>
            </div>
          </div>
          <div class="col-md-4 col-sm-6 portfolio-item">
            <a class="portfolio-link" data-toggle="modal" href="#portfolioModal2">
              <div class="portfolio-hover">
                <div class="portfolio-hover-content">
                  <i class="fas fa-plus fa-3x"></i>
                </div>
              </div>
              <img class="img-fluid" src="../img/Veiculos/fit-veiculos-home.png" alt="">
            </a>
            <div class="portfolio-caption">
              <h4>Honda Fit</h4>
              <p class="text-muted">Texto a definir</p>
            </div>
          </div>
          <div class="col-md-4 col-sm-6 portfolio-item">
            <a class="portfolio-link" data-toggle="modal" href="#portfolioModal3">
              <div class="portfolio-hover">
                <div class="portfolio-hover-content">
                  <i class="fas fa-plus fa-3x"></i>
                </div>
              </div>
              <img class="img-fluid" src="../img/Veiculos/hb20-veiculos-home.png" alt="">
            </a>
            <div class="portfolio-caption">
              <h4>Hyundai HB20</h4>
              <p class="text-muted">Texto a definir</p>
            </div>
          </div>
          <div class="col-md-4 col-sm-6 portfolio-item">
            <a class="portfolio-link" data-toggle="modal" href="#portfolioModal4">
              <div class="portfolio-hover">
                <div class="portfolio-hover-content">
                  <i class="fas fa-plus fa-3x"></i>
                </div>
              </div>
              <img class="img-fluid" src="../img/Veiculos/onix-veiculos-home.png" alt="">
            </a>
            <div class="portfolio-caption">
              <h4>Chevrolet Onix</h4>
              <p class="text-muted">Texto a definir</p>
            </div>
          </div>
          <div class="col-md-4 col-sm-6 portfolio-item">
            <a class="portfolio-link" data-toggle="modal" href="#portfolioModal5">
              <div class="portfolio-hover">
                <div class="portfolio-hover-content">
                  <i class="fas fa-plus fa-3x"></i>
                </div>
              </div>
              <img class="img-fluid" src="../img/Veiculos/polo-veiculos-home.png" alt="">
            </a>
            <div class="portfolio-caption">
              <h4>VolksWagen Polo</h4>
              <p class="text-muted">Texto a definir</p>
            </div>
          </div>
          <div class="col-md-4 col-sm-6 portfolio-item">
            <a class="portfolio-link" data-toggle="modal" href="#portfolioModal6">
              <div class="portfolio-hover">
                <div class="portfolio-hover-content">
                  <i class="fas fa-plus fa-3x"></i>
                </div>
              </div>
              <img class="img-fluid" src="../img/Veiculos/sandero-veiculos-home.png" alt="">
            </a>
            <div class="portfolio-caption">
              <h4>Renault Sandero</h4>
              <p class="text-muted">Texto a definir</p>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- Empresa -->
    <section id="empresa">
      <div class="container">
        <div class="row">
          <div class="col-lg-12 text-center">
            <h2 class="section-heading text-uppercase">A Empresa</h2>
            <h3 class="section-subheading text-muted">Texto a definir</h3>
          </div>
        </div>
        <div class="row">
          <div class="col-lg-12">
            <ul class="timeline">
              <li>
                <div class="timeline-image">
                  <img class="rounded-circle img-fluid" src="../img/Empresa/empresa-eficiencia.png" alt="" >
                </div>
                <div class="timeline-panel">
                  <div class="timeline-heading">
                    <h4>Maior Eficiencia</h4>
                    <h4 class="subheading">Aumente sua produtividade</h4>
                  </div>
                  <div class="timeline-body">
                    <p class="text-muted">Texto a definir</p>
                  </div>
                </div>
              </li>
              <li class="timeline-inverted">
                <div class="timeline-image">
                  <img class="rounded-circle img-fluid" src="../img/Empresa/empresa-seguranca.png" alt="" >
                </div>
                <div class="timeline-panel">
                  <div class="timeline-heading">
                    <h4>Maior Segurança</h4>
                    <h4 class="subheading">Garantia pelo seriço prestado</h4>
                  </div>
                  <div class="timeline-body">
                    <p class="text-muted">Texto a definir</p>
                  </div>
                </div>
              </li>
              <li>
                <div class="timeline-image">
                  <img class="rounded-circle img-fluid" src="../img/Empresa/empresa-qualidade.png" alt="" >
                </div>
                <div class="timeline-panel">
                  <div class="timeline-heading">
                    <h4>Qualidade Absolura</h4>
                    <h4 class="subheading">Fazemos bem para atender sempre</h4>
                  </div>
                  <div class="timeline-body">
                    <p class="text-muted">Texto a definir</p>
                  </div>
                </div>
              </li>
              <li class="timeline-inverted">
                <div class="timeline-image">
                  <img class="rounded-circle img-fluid" src="../img/Empresa/empresa-economia.png"  alt="" >
                </div>
                <div class="timeline-panel">
                  <div class="timeline-heading">
                    <h4>Economia</h4>
                    <h4 class="subheading">Economize mais com nossa Gestão de Frotas</h4>
                  </div>
                  <div class="timeline-body">
                    <p class="text-muted">Texto a definir</p>
                  </div>
                </div>
              </li>
              <li class="timeline-inverted">
                <div class="timeline-image">
                  <h4>Be Part
                    <br>Of Our
                    <br>Story!</h4>
                </div>
              </li>
            </ul>
          </div>
        </div>
      </div>
    </section>
          
    <!-- Contato -->
    <section id="contato">
      <div class="container">
        <div class="row">
          <div class="col-lg-12 text-center">
            <h2 class="section-heading text-uppercase">Contato</h2>
            <h3 class="section-subheading text-muted">Lider absoluta em gestão de frotas.</h3>
          </div>
        </div>
        <div class="row">
          <div class="col-lg-12">
            <form id="contactForm" name="sentMessage" novalidate="novalidate">
              <div class="row">
                <div class="col-md-6">
                  <div class="form-group">
                    <input class="form-control" id="name" type="text" placeholder="Digite seu Nome *" required="required" data-validation-required-message="Por favor digite seu nome.">
                    <p class="help-block text-danger"></p>
                  </div>
                  <div class="form-group">
                    <input class="form-control" id="email" type="email" placeholder="Digite seu Email *" required="required" data-validation-required-message="Por favor digite o e-mail.">
                    <p class="help-block text-danger"></p>
                  </div>
                  <div class="form-group">
                    <input class="form-control" id="phone" type="tel" placeholder="Digite seu Telefone *" required="required" data-validation-required-message="Por favor digite o numero de telefone.">
                    <p class="help-block text-danger"></p>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="form-group">
                    <textarea class="form-control" id="message" placeholder="Digite a messagem, em breve retornamos *" required="required" data-validation-required-message="Por favor digite a mensagem."></textarea>
                    <p class="help-block text-danger"></p>
                  </div>
                </div>
                <div class="clearfix"></div>
                <div class="col-lg-12 text-center">
                  <div id="success"></div>
                  <button id="sendMessageButton" class="btn btn-primary btn-xl text-uppercase" type="submit">Enviar Mensagem</button>
                </div>
              </div>
            </form>
          </div>
        </div>
      </div>
    </section>

    <!-- Footer -->
    <footer>
      <div class="container">
        <div class="row">
          <div class="col-md-4">
            <span class="copyright">Copyright &copy; Clucth Kinetcs 2019</span>
          </div>
          <div class="col-md-4">
            <ul class="list-inline social-buttons">
              <li class="list-inline-item">
                <a href="#">
                  <i class="fab fa-twitter"></i>
                </a>
              </li>
              <li class="list-inline-item">
                <a href="#">
                  <i class="fab fa-facebook-f"></i>
                </a>
              </li>
              <li class="list-inline-item">
                <a href="#">
                  <i class="fab fa-linkedin-in"></i>
                </a>
              </li>
            </ul>
          </div>
         </div>
      </div>
    </footer>

    <!-- Portfolio Modals -->

    <!-- Modal 1 -->
    <div class="portfolio-modal modal fade" id="portfolioModal1" tabindex="-1" role="dialog" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="close-modal" data-dismiss="modal">
            <div class="lr">
              <div class="rl"></div>
            </div>
          </div>
          <div class="container">
            <div class="row">
              <div class="col-lg-8 mx-auto">
                <div class="modal-body">


                  <!-- Project Details Go Here -->
                  <h2 class="text-uppercase">Fiat Argo</h2>
                  <p class="item-intro text-muted">Economia, Tecnologia e Segurança</p>
                  <img class="img-fluid d-block mx-auto" src="../img/Veiculos/Descricao/argo-veiculo-descricao.jpg" alt="">
                  <p>Texto a definir</p>
                  <ul class="list-inline">
                    <li>Ano: 2019 modelo 2010</li>
                    <li>Marca: Fiat</li>
                    <li>Modelo: Argo</li>
                  </ul>
                  <button class="btn btn-primary" data-dismiss="modal" type="button">
                    <i class="fas fa-times"></i>
                    Reserve Agora</button>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <!-- Modal 2 -->
    <div class="portfolio-modal modal fade" id="portfolioModal2" tabindex="-1" role="dialog" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="close-modal" data-dismiss="modal">
            <div class="lr">
              <div class="rl"></div>
            </div>
          </div>
          <div class="container">
            <div class="row">
              <div class="col-lg-8 mx-auto">
                <div class="modal-body">


                  <!-- Project Details Go Here -->
                  <h2 class="text-uppercase">Texto a definir</h2>
                  <p class="item-intro text-muted">Texto a definir</p>
                  <img class="img-fluid d-block mx-auto" src="img/portfolio/02-full.jpg" alt="">
                  <p>Texto a definir</p>
                  <ul class="list-inline">
                    <li>Texto a definir</li>
                    <li>Texto a definir</li>
                    <li>Texto a definir</li>
                  </ul>
                  <button class="btn btn-primary" data-dismiss="modal" type="button">
                    <i class="fas fa-times"></i>
                    Reserve Agora</button>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <!-- Modal 3 -->
    <div class="portfolio-modal modal fade" id="portfolioModal3" tabindex="-1" role="dialog" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="close-modal" data-dismiss="modal">
            <div class="lr">
              <div class="rl"></div>
            </div>
          </div>
          <div class="container">
            <div class="row">
              <div class="col-lg-8 mx-auto">
                <div class="modal-body">


                  <!-- Project Details Go Here -->
                  <h2 class="text-uppercase"></h2>
                  <p class="item-intro text-muted">Texto a definir</p>
                  <img class="img-fluid d-block mx-auto" src="img/portfolio/03-full.jpg" alt="">
                  <p>Texto a definir</p>
                  <ul class="list-inline">
                    <li>Texto a definir</li>
                    <li>Texto a definir</li>
                    <li>Texto a definir</li>
                  </ul>
                  <button class="btn btn-primary" data-dismiss="modal" type="button">
                    <i class="fas fa-times"></i>
                    Reserve Agora</button>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <!-- Modal 4 -->
    <div class="portfolio-modal modal fade" id="portfolioModal4" tabindex="-1" role="dialog" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="close-modal" data-dismiss="modal">
            <div class="lr">
              <div class="rl"></div>
            </div>
          </div>
          <div class="container">
            <div class="row">
              <div class="col-lg-8 mx-auto">
                <div class="modal-body">


                  <!-- Project Details Go Here -->
                  <h2 class="text-uppercase">Texto a definir</h2>
                  <p class="item-intro text-muted">Texto a definir</p>
                  <img class="img-fluid d-block mx-auto" src="img/portfolio/04-full.jpg" alt="">
                  <p>Texto a definir</p>
                  <ul class="list-inline">
                    <li>Texto a definir</li>
                    <li>Texto a definir</li>
                    <li>Texto a definir</li>
                  </ul>
                  <button class="btn btn-primary" data-dismiss="modal" type="button">
                    <i class="fas fa-times"></i>
                    Reserve Agora</button>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <!-- Modal 5 -->
    <div class="portfolio-modal modal fade" id="portfolioModal5" tabindex="-1" role="dialog" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="close-modal" data-dismiss="modal">
            <div class="lr">
              <div class="rl"></div>
            </div>
          </div>
          <div class="container">
            <div class="row">
              <div class="col-lg-8 mx-auto">
                <div class="modal-body">


                  <!-- Project Details Go Here -->
                  <h2 class="text-uppercase">Texto a definir</h2>
                  <p class="item-intro text-muted">Texto a definir</p>
                  <img class="img-fluid d-block mx-auto" src="img/portfolio/05-full.jpg" alt="">
                  <p>Texto a definir</p>
                  <ul class="list-inline">
                    <li>Texto a definir</li>
                    <li>Texto a definir</li>
                    <li>Texto a definir</li>
                  </ul>
                  <button class="btn btn-primary" data-dismiss="modal" type="button">
                    <i class="fas fa-times"></i>
                    Reserve Agora</button>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <!-- Modal 6 -->
    <div class="portfolio-modal modal fade" id="portfolioModal6" tabindex="-1" role="dialog" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="close-modal" data-dismiss="modal">
            <div class="lr">
              <div class="rl"></div>
            </div>
          </div>
          <div class="container">
            <div class="row">
              <div class="col-lg-8 mx-auto">
                <div class="modal-body">
                  <!-- Project Details Go Here -->
                  <h2 class="text-uppercase">Texto a definir</h2>
                  <p class="item-intro text-muted">Texto a definir</p>
                  <img class="img-fluid d-block mx-auto" src="img/portfolio/06-full.jpg" alt="">
                  <p>Texto a definir</p>
                  <ul class="list-inline">
                    <li>Texto a definir</li>
                    <li>Texto a definir</li>
                    <li>Texto a definir</li>
                  </ul>
                  <button class="btn btn-primary" data-dismiss="modal" type="button">
                    <i class="fas fa-times"></i>
                    Reserve Agora</button>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <!-- Bootstrap core JavaScript -->
    

    <script src="../Scripts/bootstrap.bundle.min.js"></script>
    <script src="../Scripts/jquery.min.js"></script>
   
       <!-- Plugin JavaScript -->   
     <script src="../Scripts/jquery.easing.min.js"></script>

    <!-- Custom scripts for this template -->
    <script src="../Scripts/kinects.min.js"></script>

      </body>
</html>
