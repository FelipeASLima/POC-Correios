﻿//------------------------------------------------------------------------------
// <gerado automaticamente>
//     Esse código foi gerado por uma ferramenta.
//     //
//     As alterações no arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </gerado automaticamente>
//------------------------------------------------------------------------------

namespace ServiceReferenceCorreios
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class SQLException
    {
        
        private int errorCodeField;
        
        private bool errorCodeFieldSpecified;
        
        private string sQLStateField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int errorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool errorCodeSpecified
        {
            get
            {
                return this.errorCodeFieldSpecified;
            }
            set
            {
                this.errorCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string sQLState
        {
            get
            {
                return this.sQLStateField;
            }
            set
            {
                this.sQLStateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class servicoAdicionalXML
    {
        
        private string categoriaField;
        
        private string codigoField;
        
        private string descricaoField;
        
        private double maximoValorDeclaradoField;
        
        private bool maximoValorDeclaradoFieldSpecified;
        
        private double minimoValorDeclaradoField;
        
        private bool minimoValorDeclaradoFieldSpecified;
        
        private string siglaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string categoria
        {
            get
            {
                return this.categoriaField;
            }
            set
            {
                this.categoriaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public double maximoValorDeclarado
        {
            get
            {
                return this.maximoValorDeclaradoField;
            }
            set
            {
                this.maximoValorDeclaradoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximoValorDeclaradoSpecified
        {
            get
            {
                return this.maximoValorDeclaradoFieldSpecified;
            }
            set
            {
                this.maximoValorDeclaradoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public double minimoValorDeclarado
        {
            get
            {
                return this.minimoValorDeclaradoField;
            }
            set
            {
                this.minimoValorDeclaradoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimoValorDeclaradoSpecified
        {
            get
            {
                return this.minimoValorDeclaradoFieldSpecified;
            }
            set
            {
                this.minimoValorDeclaradoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string sigla
        {
            get
            {
                return this.siglaField;
            }
            set
            {
                this.siglaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class Exception
    {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class ErroMontagemRelatorio
    {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", ConfigurationName="ServiceReferenceCorreios.AtendeCliente")]
    public interface AtendeCliente
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReferenceCorreios.SQLException), Action="", Name="SQLException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaServicosAdicionaisAtivosResponse> buscaServicosAdicionaisAtivosAsync(ServiceReferenceCorreios.buscaServicosAdicionaisAtivos request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.fechaPlpResponse> fechaPlpAsync(ServiceReferenceCorreios.fechaPlp request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReferenceCorreios.Exception), Action="", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.calculaTarifaServicoResponse> calculaTarifaServicoAsync(ServiceReferenceCorreios.calculaTarifaServico request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.validaPlpResponse> validaPlpAsync(ServiceReferenceCorreios.validaPlp request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.VerificaSeTodosObjetosCanceladosResponse> VerificaSeTodosObjetosCanceladosAsync(ServiceReferenceCorreios.VerificaSeTodosObjetosCancelados request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReferenceCorreios.Exception), Action="", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.cancelarObjetoResponse> cancelarObjetoAsync(ServiceReferenceCorreios.cancelarObjeto request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.pesquisarParametrosPorDescricaoResponse> pesquisarParametrosPorDescricaoAsync(ServiceReferenceCorreios.pesquisarParametrosPorDescricao request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReferenceCorreios.SQLException), Action="", Name="SQLException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.atualizaPagamentoNaEntregaResponse> atualizaPagamentoNaEntregaAsync(ServiceReferenceCorreios.atualizaPagamentoNaEntrega request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.obterClienteAtualizacaoResponse> obterClienteAtualizacaoAsync(ServiceReferenceCorreios.obterClienteAtualizacao request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.verificaDisponibilidadeServicoResponse> verificaDisponibilidadeServicoAsync(ServiceReferenceCorreios.verificaDisponibilidadeServico request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.fechaPlpVariosServicosResponse> fechaPlpVariosServicosAsync(ServiceReferenceCorreios.fechaPlpVariosServicos request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.geraDigitoVerificadorEtiquetasResponse> geraDigitoVerificadorEtiquetasAsync(ServiceReferenceCorreios.geraDigitoVerificadorEtiquetas request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.obterEmbalagemLRSResponse> obterEmbalagemLRSAsync(ServiceReferenceCorreios.obterEmbalagemLRS request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.validaEtiquetaPLPResponse> validaEtiquetaPLPAsync(ServiceReferenceCorreios.validaEtiquetaPLP request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReferenceCorreios.SQLException), Action="", Name="SQLException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaServicosValorDeclaradoResponse> buscaServicosValorDeclaradoAsync(ServiceReferenceCorreios.buscaServicosValorDeclarado request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReferenceCorreios.SQLException), Action="", Name="SQLException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.consultaCEPResponse> consultaCEPAsync(ServiceReferenceCorreios.consultaCEP request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.integrarUsuarioScolResponse> integrarUsuarioScolAsync(ServiceReferenceCorreios.integrarUsuarioScol request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.pesquisarDimensoesServicoResponse> pesquisarDimensoesServicoAsync(ServiceReferenceCorreios.pesquisarDimensoesServico request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.pesquisarEmbalagensPorServicoResponse> pesquisarEmbalagensPorServicoAsync(ServiceReferenceCorreios.pesquisarEmbalagensPorServico request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReferenceCorreios.SQLException), Action="", Name="SQLException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.atualizaRemessaAgrupadaResponse> atualizaRemessaAgrupadaAsync(ServiceReferenceCorreios.atualizaRemessaAgrupada request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.solicitaPLPResponse> solicitaPLPAsync(ServiceReferenceCorreios.solicitaPLP request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.getStatusCartaoPostagemResponse> getStatusCartaoPostagemAsync(ServiceReferenceCorreios.getStatusCartaoPostagem request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.verificaModalTransporteResponse> verificaModalTransporteAsync(ServiceReferenceCorreios.verificaModalTransporte request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaDataAtualResponse> buscaDataAtualAsync(ServiceReferenceCorreios.buscaDataAtual request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReferenceCorreios.Exception), Action="", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaTarifaValeResponse> buscaTarifaValeAsync(ServiceReferenceCorreios.buscaTarifaVale request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.validarPostagemSimultaneaResponse> validarPostagemSimultaneaAsync(ServiceReferenceCorreios.validarPostagemSimultanea request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.getStatusPLPResponse> getStatusPLPAsync(ServiceReferenceCorreios.getStatusPLP request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.pesquisarServicosAdicionaisResponse> pesquisarServicosAdicionaisAsync(ServiceReferenceCorreios.pesquisarServicosAdicionais request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReferenceCorreios.SQLException), Action="", Name="SQLException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaServicosXServicosAdicionaisResponse> buscaServicosXServicosAdicionaisAsync(ServiceReferenceCorreios.buscaServicosXServicosAdicionais request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.cancelarPedidoScolResponse> cancelarPedidoScolAsync(ServiceReferenceCorreios.cancelarPedidoScol request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.bloquearObjetoResponse> bloquearObjetoAsync(ServiceReferenceCorreios.bloquearObjeto request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaContratoResponse> buscaContratoAsync(ServiceReferenceCorreios.buscaContrato request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.solicitaEtiquetasResponse> solicitaEtiquetasAsync(ServiceReferenceCorreios.solicitaEtiquetas request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.solicitaXmlPlpResponse> solicitaXmlPlpAsync(ServiceReferenceCorreios.solicitaXmlPlp request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.validarPostagemReversaResponse> validarPostagemReversaAsync(ServiceReferenceCorreios.validarPostagemReversa request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaClienteResponse> buscaClienteAsync(ServiceReferenceCorreios.buscaCliente request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReferenceCorreios.ErroMontagemRelatorio), Action="", Name="ErroMontagemRelatorio")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaPagamentoEntregaResponse> buscaPagamentoEntregaAsync(ServiceReferenceCorreios.buscaPagamentoEntrega request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.solicitarPostagemScolResponse> solicitarPostagemScolAsync(ServiceReferenceCorreios.solicitarPostagemScol request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="AutenticacaoException")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaServicosResponse> buscaServicosAsync(ServiceReferenceCorreios.buscaServicos request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.obterMensagemParametrizadaResponse> obterMensagemParametrizadaAsync(ServiceReferenceCorreios.obterMensagemParametrizada request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="", Name="SigepClienteException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaOpcoesResponse> buscaOpcoesAsync(ServiceReferenceCorreios.buscaOpcoes request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaServicosAdicionaisAtivos", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaServicosAdicionaisAtivos
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public buscaServicosAdicionaisAtivos()
        {
        }
        
        public buscaServicosAdicionaisAtivos(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaServicosAdicionaisAtivosResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaServicosAdicionaisAtivosResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.servicoAdicionalXML[] @return;
        
        public buscaServicosAdicionaisAtivosResponse()
        {
        }
        
        public buscaServicosAdicionaisAtivosResponse(ServiceReferenceCorreios.servicoAdicionalXML[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="fechaPlp", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class fechaPlp
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string xml;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idPlpCliente;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cartaoPostagem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string faixaEtiquetas;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public fechaPlp()
        {
        }
        
        public fechaPlp(string xml, long idPlpCliente, string cartaoPostagem, string faixaEtiquetas, string usuario, string senha)
        {
            this.xml = xml;
            this.idPlpCliente = idPlpCliente;
            this.cartaoPostagem = cartaoPostagem;
            this.faixaEtiquetas = faixaEtiquetas;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="fechaPlpResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class fechaPlpResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long @return;
        
        public fechaPlpResponse()
        {
        }
        
        public fechaPlpResponse(long @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="calculaTarifaServico", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class calculaTarifaServico
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codAdministrativo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codServico;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cepOrigem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cepDestino;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string peso;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int codFormato;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double comprimento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=9)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double altura;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=10)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double largura;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=11)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double diametro;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=12)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codMaoPropria;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=13)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double valorDeclarado;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=14)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codAvisoRecebimento;
        
        public calculaTarifaServico()
        {
        }
        
        public calculaTarifaServico(string codAdministrativo, string usuario, string senha, string codServico, string cepOrigem, string cepDestino, string peso, int codFormato, double comprimento, double altura, double largura, double diametro, string codMaoPropria, double valorDeclarado, string codAvisoRecebimento)
        {
            this.codAdministrativo = codAdministrativo;
            this.usuario = usuario;
            this.senha = senha;
            this.codServico = codServico;
            this.cepOrigem = cepOrigem;
            this.cepDestino = cepDestino;
            this.peso = peso;
            this.codFormato = codFormato;
            this.comprimento = comprimento;
            this.altura = altura;
            this.largura = largura;
            this.diametro = diametro;
            this.codMaoPropria = codMaoPropria;
            this.valorDeclarado = valorDeclarado;
            this.codAvisoRecebimento = codAvisoRecebimento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="calculaTarifaServicoResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class calculaTarifaServicoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public calculaTarifaServicoResponse()
        {
        }
        
        public calculaTarifaServicoResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validaPlp", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class validaPlp
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long cliente;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numero;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long diretoria;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cartao;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string unidadePostagem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long servico;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute("servicosAdicionais", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] servicosAdicionais;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public validaPlp()
        {
        }
        
        public validaPlp(long cliente, string numero, long diretoria, string cartao, string unidadePostagem, long servico, string[] servicosAdicionais, string usuario, string senha)
        {
            this.cliente = cliente;
            this.numero = numero;
            this.diretoria = diretoria;
            this.cartao = cartao;
            this.unidadePostagem = unidadePostagem;
            this.servico = servico;
            this.servicosAdicionais = servicosAdicionais;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validaPlpResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class validaPlpResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public validaPlpResponse()
        {
        }
        
        public validaPlpResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class objetoPostal
    {
        
        private string codigoEtiquetaField;
        
        private System.DateTime dataAtualizacaoClienteField;
        
        private bool dataAtualizacaoClienteFieldSpecified;
        
        private System.DateTime dataBloqueioObjetoField;
        
        private bool dataBloqueioObjetoFieldSpecified;
        
        private System.DateTime dataCancelamentoEtiquetaField;
        
        private bool dataCancelamentoEtiquetaFieldSpecified;
        
        private System.DateTime dataInclusaoField;
        
        private bool dataInclusaoFieldSpecified;
        
        private objetoPostalPK objetoPostalPKField;
        
        private long plpNuField;
        
        private bool plpNuFieldSpecified;
        
        private preListaPostagem preListaPostagemField;
        
        private simNao restricaoAereaField;
        
        private bool restricaoAereaFieldSpecified;
        
        private string statusBloqueioField;
        
        private statusObjetoPostal statusEtiquetaField;
        
        private bool statusEtiquetaFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string codigoEtiqueta
        {
            get
            {
                return this.codigoEtiquetaField;
            }
            set
            {
                this.codigoEtiquetaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public System.DateTime dataAtualizacaoCliente
        {
            get
            {
                return this.dataAtualizacaoClienteField;
            }
            set
            {
                this.dataAtualizacaoClienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataAtualizacaoClienteSpecified
        {
            get
            {
                return this.dataAtualizacaoClienteFieldSpecified;
            }
            set
            {
                this.dataAtualizacaoClienteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime dataBloqueioObjeto
        {
            get
            {
                return this.dataBloqueioObjetoField;
            }
            set
            {
                this.dataBloqueioObjetoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataBloqueioObjetoSpecified
        {
            get
            {
                return this.dataBloqueioObjetoFieldSpecified;
            }
            set
            {
                this.dataBloqueioObjetoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public System.DateTime dataCancelamentoEtiqueta
        {
            get
            {
                return this.dataCancelamentoEtiquetaField;
            }
            set
            {
                this.dataCancelamentoEtiquetaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataCancelamentoEtiquetaSpecified
        {
            get
            {
                return this.dataCancelamentoEtiquetaFieldSpecified;
            }
            set
            {
                this.dataCancelamentoEtiquetaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public System.DateTime dataInclusao
        {
            get
            {
                return this.dataInclusaoField;
            }
            set
            {
                this.dataInclusaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataInclusaoSpecified
        {
            get
            {
                return this.dataInclusaoFieldSpecified;
            }
            set
            {
                this.dataInclusaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public objetoPostalPK objetoPostalPK
        {
            get
            {
                return this.objetoPostalPKField;
            }
            set
            {
                this.objetoPostalPKField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public long plpNu
        {
            get
            {
                return this.plpNuField;
            }
            set
            {
                this.plpNuField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool plpNuSpecified
        {
            get
            {
                return this.plpNuFieldSpecified;
            }
            set
            {
                this.plpNuFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public preListaPostagem preListaPostagem
        {
            get
            {
                return this.preListaPostagemField;
            }
            set
            {
                this.preListaPostagemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public simNao restricaoAerea
        {
            get
            {
                return this.restricaoAereaField;
            }
            set
            {
                this.restricaoAereaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool restricaoAereaSpecified
        {
            get
            {
                return this.restricaoAereaFieldSpecified;
            }
            set
            {
                this.restricaoAereaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string statusBloqueio
        {
            get
            {
                return this.statusBloqueioField;
            }
            set
            {
                this.statusBloqueioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public statusObjetoPostal statusEtiqueta
        {
            get
            {
                return this.statusEtiquetaField;
            }
            set
            {
                this.statusEtiquetaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusEtiquetaSpecified
        {
            get
            {
                return this.statusEtiquetaFieldSpecified;
            }
            set
            {
                this.statusEtiquetaFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class objetoPostalPK
    {
        
        private string codigoEtiquetaField;
        
        private long plpNuField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string codigoEtiqueta
        {
            get
            {
                return this.codigoEtiquetaField;
            }
            set
            {
                this.codigoEtiquetaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public long plpNu
        {
            get
            {
                return this.plpNuField;
            }
            set
            {
                this.plpNuField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class preListaPostagem
    {
        
        private cartaoPostagemERP cartaoPostagemField;
        
        private simNao conteudoProibidoField;
        
        private bool conteudoProibidoFieldSpecified;
        
        private System.DateTime dataAtualizacaoClienteField;
        
        private bool dataAtualizacaoClienteFieldSpecified;
        
        private System.DateTime dataAtualizacaoSaraField;
        
        private bool dataAtualizacaoSaraFieldSpecified;
        
        private System.DateTime dataFechamentoField;
        
        private bool dataFechamentoFieldSpecified;
        
        private System.DateTime dataPostagemField;
        
        private bool dataPostagemFieldSpecified;
        
        private System.DateTime dataPostagemSaraField;
        
        private bool dataPostagemSaraFieldSpecified;
        
        private objetoPostal[] objetosPostaisField;
        
        private long plpClienteField;
        
        private long plpNuField;
        
        private System.Nullable<ushort>[] plpXmlField;
        
        private System.Nullable<ushort>[] plpXmlRetornoField;
        
        private statusPlp statusField;
        
        private bool statusFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public cartaoPostagemERP cartaoPostagem
        {
            get
            {
                return this.cartaoPostagemField;
            }
            set
            {
                this.cartaoPostagemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public simNao conteudoProibido
        {
            get
            {
                return this.conteudoProibidoField;
            }
            set
            {
                this.conteudoProibidoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool conteudoProibidoSpecified
        {
            get
            {
                return this.conteudoProibidoFieldSpecified;
            }
            set
            {
                this.conteudoProibidoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime dataAtualizacaoCliente
        {
            get
            {
                return this.dataAtualizacaoClienteField;
            }
            set
            {
                this.dataAtualizacaoClienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataAtualizacaoClienteSpecified
        {
            get
            {
                return this.dataAtualizacaoClienteFieldSpecified;
            }
            set
            {
                this.dataAtualizacaoClienteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public System.DateTime dataAtualizacaoSara
        {
            get
            {
                return this.dataAtualizacaoSaraField;
            }
            set
            {
                this.dataAtualizacaoSaraField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataAtualizacaoSaraSpecified
        {
            get
            {
                return this.dataAtualizacaoSaraFieldSpecified;
            }
            set
            {
                this.dataAtualizacaoSaraFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public System.DateTime dataFechamento
        {
            get
            {
                return this.dataFechamentoField;
            }
            set
            {
                this.dataFechamentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataFechamentoSpecified
        {
            get
            {
                return this.dataFechamentoFieldSpecified;
            }
            set
            {
                this.dataFechamentoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public System.DateTime dataPostagem
        {
            get
            {
                return this.dataPostagemField;
            }
            set
            {
                this.dataPostagemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataPostagemSpecified
        {
            get
            {
                return this.dataPostagemFieldSpecified;
            }
            set
            {
                this.dataPostagemFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public System.DateTime dataPostagemSara
        {
            get
            {
                return this.dataPostagemSaraField;
            }
            set
            {
                this.dataPostagemSaraField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataPostagemSaraSpecified
        {
            get
            {
                return this.dataPostagemSaraFieldSpecified;
            }
            set
            {
                this.dataPostagemSaraFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("objetosPostais", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=7)]
        public objetoPostal[] objetosPostais
        {
            get
            {
                return this.objetosPostaisField;
            }
            set
            {
                this.objetosPostaisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public long plpCliente
        {
            get
            {
                return this.plpClienteField;
            }
            set
            {
                this.plpClienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public long plpNu
        {
            get
            {
                return this.plpNuField;
            }
            set
            {
                this.plpNuField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("plpXml", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=10)]
        public System.Nullable<ushort>[] plpXml
        {
            get
            {
                return this.plpXmlField;
            }
            set
            {
                this.plpXmlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("plpXmlRetorno", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=11)]
        public System.Nullable<ushort>[] plpXmlRetorno
        {
            get
            {
                return this.plpXmlRetornoField;
            }
            set
            {
                this.plpXmlRetornoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public statusPlp status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class cartaoPostagemERP
    {
        
        private string codigoAdministrativoField;
        
        private contratoERP[] contratosField;
        
        private System.DateTime dataAtualizacaoField;
        
        private bool dataAtualizacaoFieldSpecified;
        
        private System.DateTime dataVigenciaFimField;
        
        private bool dataVigenciaFimFieldSpecified;
        
        private System.DateTime dataVigenciaInicioField;
        
        private bool dataVigenciaInicioFieldSpecified;
        
        private int datajAtualizacaoField;
        
        private bool datajAtualizacaoFieldSpecified;
        
        private int datajVigenciaFimField;
        
        private bool datajVigenciaFimFieldSpecified;
        
        private int datajVigenciaInicioField;
        
        private bool datajVigenciaInicioFieldSpecified;
        
        private string descricaoStatusCartaoField;
        
        private string descricaoUnidadePostagemGenericaField;
        
        private int horajAtualizacaoField;
        
        private bool horajAtualizacaoFieldSpecified;
        
        private string numeroField;
        
        private servicoERP[] servicosField;
        
        private string statusCartaoPostagemField;
        
        private string statusCodigoField;
        
        private string unidadeGenericaField;
        
        private unidadePostagemERP[] unidadesPostagemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string codigoAdministrativo
        {
            get
            {
                return this.codigoAdministrativoField;
            }
            set
            {
                this.codigoAdministrativoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contratos", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public contratoERP[] contratos
        {
            get
            {
                return this.contratosField;
            }
            set
            {
                this.contratosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime dataAtualizacao
        {
            get
            {
                return this.dataAtualizacaoField;
            }
            set
            {
                this.dataAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataAtualizacaoSpecified
        {
            get
            {
                return this.dataAtualizacaoFieldSpecified;
            }
            set
            {
                this.dataAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public System.DateTime dataVigenciaFim
        {
            get
            {
                return this.dataVigenciaFimField;
            }
            set
            {
                this.dataVigenciaFimField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataVigenciaFimSpecified
        {
            get
            {
                return this.dataVigenciaFimFieldSpecified;
            }
            set
            {
                this.dataVigenciaFimFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public System.DateTime dataVigenciaInicio
        {
            get
            {
                return this.dataVigenciaInicioField;
            }
            set
            {
                this.dataVigenciaInicioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataVigenciaInicioSpecified
        {
            get
            {
                return this.dataVigenciaInicioFieldSpecified;
            }
            set
            {
                this.dataVigenciaInicioFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int datajAtualizacao
        {
            get
            {
                return this.datajAtualizacaoField;
            }
            set
            {
                this.datajAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datajAtualizacaoSpecified
        {
            get
            {
                return this.datajAtualizacaoFieldSpecified;
            }
            set
            {
                this.datajAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int datajVigenciaFim
        {
            get
            {
                return this.datajVigenciaFimField;
            }
            set
            {
                this.datajVigenciaFimField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datajVigenciaFimSpecified
        {
            get
            {
                return this.datajVigenciaFimFieldSpecified;
            }
            set
            {
                this.datajVigenciaFimFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int datajVigenciaInicio
        {
            get
            {
                return this.datajVigenciaInicioField;
            }
            set
            {
                this.datajVigenciaInicioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datajVigenciaInicioSpecified
        {
            get
            {
                return this.datajVigenciaInicioFieldSpecified;
            }
            set
            {
                this.datajVigenciaInicioFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string descricaoStatusCartao
        {
            get
            {
                return this.descricaoStatusCartaoField;
            }
            set
            {
                this.descricaoStatusCartaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string descricaoUnidadePostagemGenerica
        {
            get
            {
                return this.descricaoUnidadePostagemGenericaField;
            }
            set
            {
                this.descricaoUnidadePostagemGenericaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public int horajAtualizacao
        {
            get
            {
                return this.horajAtualizacaoField;
            }
            set
            {
                this.horajAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horajAtualizacaoSpecified
        {
            get
            {
                return this.horajAtualizacaoFieldSpecified;
            }
            set
            {
                this.horajAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("servicos", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=12)]
        public servicoERP[] servicos
        {
            get
            {
                return this.servicosField;
            }
            set
            {
                this.servicosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string statusCartaoPostagem
        {
            get
            {
                return this.statusCartaoPostagemField;
            }
            set
            {
                this.statusCartaoPostagemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string statusCodigo
        {
            get
            {
                return this.statusCodigoField;
            }
            set
            {
                this.statusCodigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string unidadeGenerica
        {
            get
            {
                return this.unidadeGenericaField;
            }
            set
            {
                this.unidadeGenericaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unidadesPostagem", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=16)]
        public unidadePostagemERP[] unidadesPostagem
        {
            get
            {
                return this.unidadesPostagemField;
            }
            set
            {
                this.unidadesPostagemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class contratoERP
    {
        
        private cartaoPostagemERP[] cartoesPostagemField;
        
        private clienteERP clienteField;
        
        private long codigoClienteField;
        
        private string codigoDiretoriaField;
        
        private contratoERPPK contratoPKField;
        
        private System.DateTime dataAtualizacaoField;
        
        private bool dataAtualizacaoFieldSpecified;
        
        private string dataAtualizacaoDDMMYYYYField;
        
        private System.DateTime dataVigenciaFimField;
        
        private bool dataVigenciaFimFieldSpecified;
        
        private string dataVigenciaFimDDMMYYYYField;
        
        private System.DateTime dataVigenciaInicioField;
        
        private bool dataVigenciaInicioFieldSpecified;
        
        private string dataVigenciaInicioDDMMYYYYField;
        
        private int datajAtualizacaoField;
        
        private bool datajAtualizacaoFieldSpecified;
        
        private int datajVigenciaFimField;
        
        private bool datajVigenciaFimFieldSpecified;
        
        private int datajVigenciaInicioField;
        
        private bool datajVigenciaInicioFieldSpecified;
        
        private string descricaoDiretoriaRegionalField;
        
        private string descricaoStatusField;
        
        private unidadePostagemERP diretoriaRegionalField;
        
        private int horajAtualizacaoField;
        
        private bool horajAtualizacaoFieldSpecified;
        
        private string statusCodigoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cartoesPostagem", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public cartaoPostagemERP[] cartoesPostagem
        {
            get
            {
                return this.cartoesPostagemField;
            }
            set
            {
                this.cartoesPostagemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public clienteERP cliente
        {
            get
            {
                return this.clienteField;
            }
            set
            {
                this.clienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public long codigoCliente
        {
            get
            {
                return this.codigoClienteField;
            }
            set
            {
                this.codigoClienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string codigoDiretoria
        {
            get
            {
                return this.codigoDiretoriaField;
            }
            set
            {
                this.codigoDiretoriaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public contratoERPPK contratoPK
        {
            get
            {
                return this.contratoPKField;
            }
            set
            {
                this.contratoPKField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public System.DateTime dataAtualizacao
        {
            get
            {
                return this.dataAtualizacaoField;
            }
            set
            {
                this.dataAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataAtualizacaoSpecified
        {
            get
            {
                return this.dataAtualizacaoFieldSpecified;
            }
            set
            {
                this.dataAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string dataAtualizacaoDDMMYYYY
        {
            get
            {
                return this.dataAtualizacaoDDMMYYYYField;
            }
            set
            {
                this.dataAtualizacaoDDMMYYYYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public System.DateTime dataVigenciaFim
        {
            get
            {
                return this.dataVigenciaFimField;
            }
            set
            {
                this.dataVigenciaFimField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataVigenciaFimSpecified
        {
            get
            {
                return this.dataVigenciaFimFieldSpecified;
            }
            set
            {
                this.dataVigenciaFimFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string dataVigenciaFimDDMMYYYY
        {
            get
            {
                return this.dataVigenciaFimDDMMYYYYField;
            }
            set
            {
                this.dataVigenciaFimDDMMYYYYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public System.DateTime dataVigenciaInicio
        {
            get
            {
                return this.dataVigenciaInicioField;
            }
            set
            {
                this.dataVigenciaInicioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataVigenciaInicioSpecified
        {
            get
            {
                return this.dataVigenciaInicioFieldSpecified;
            }
            set
            {
                this.dataVigenciaInicioFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string dataVigenciaInicioDDMMYYYY
        {
            get
            {
                return this.dataVigenciaInicioDDMMYYYYField;
            }
            set
            {
                this.dataVigenciaInicioDDMMYYYYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public int datajAtualizacao
        {
            get
            {
                return this.datajAtualizacaoField;
            }
            set
            {
                this.datajAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datajAtualizacaoSpecified
        {
            get
            {
                return this.datajAtualizacaoFieldSpecified;
            }
            set
            {
                this.datajAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public int datajVigenciaFim
        {
            get
            {
                return this.datajVigenciaFimField;
            }
            set
            {
                this.datajVigenciaFimField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datajVigenciaFimSpecified
        {
            get
            {
                return this.datajVigenciaFimFieldSpecified;
            }
            set
            {
                this.datajVigenciaFimFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public int datajVigenciaInicio
        {
            get
            {
                return this.datajVigenciaInicioField;
            }
            set
            {
                this.datajVigenciaInicioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datajVigenciaInicioSpecified
        {
            get
            {
                return this.datajVigenciaInicioFieldSpecified;
            }
            set
            {
                this.datajVigenciaInicioFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string descricaoDiretoriaRegional
        {
            get
            {
                return this.descricaoDiretoriaRegionalField;
            }
            set
            {
                this.descricaoDiretoriaRegionalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string descricaoStatus
        {
            get
            {
                return this.descricaoStatusField;
            }
            set
            {
                this.descricaoStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public unidadePostagemERP diretoriaRegional
        {
            get
            {
                return this.diretoriaRegionalField;
            }
            set
            {
                this.diretoriaRegionalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public int horajAtualizacao
        {
            get
            {
                return this.horajAtualizacaoField;
            }
            set
            {
                this.horajAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horajAtualizacaoSpecified
        {
            get
            {
                return this.horajAtualizacaoFieldSpecified;
            }
            set
            {
                this.horajAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public string statusCodigo
        {
            get
            {
                return this.statusCodigoField;
            }
            set
            {
                this.statusCodigoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class clienteERP
    {
        
        private string cnpjField;
        
        private contratoERP[] contratosField;
        
        private System.DateTime dataAtualizacaoField;
        
        private bool dataAtualizacaoFieldSpecified;
        
        private int datajAtualizacaoField;
        
        private bool datajAtualizacaoFieldSpecified;
        
        private string descricaoStatusClienteField;
        
        private gerenteConta[] gerenteContaField;
        
        private long horajAtualizacaoField;
        
        private bool horajAtualizacaoFieldSpecified;
        
        private long idField;
        
        private string inscricaoEstadualField;
        
        private string nomeField;
        
        private string statusCodigoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string cnpj
        {
            get
            {
                return this.cnpjField;
            }
            set
            {
                this.cnpjField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contratos", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public contratoERP[] contratos
        {
            get
            {
                return this.contratosField;
            }
            set
            {
                this.contratosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime dataAtualizacao
        {
            get
            {
                return this.dataAtualizacaoField;
            }
            set
            {
                this.dataAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataAtualizacaoSpecified
        {
            get
            {
                return this.dataAtualizacaoFieldSpecified;
            }
            set
            {
                this.dataAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int datajAtualizacao
        {
            get
            {
                return this.datajAtualizacaoField;
            }
            set
            {
                this.datajAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datajAtualizacaoSpecified
        {
            get
            {
                return this.datajAtualizacaoFieldSpecified;
            }
            set
            {
                this.datajAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string descricaoStatusCliente
        {
            get
            {
                return this.descricaoStatusClienteField;
            }
            set
            {
                this.descricaoStatusClienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gerenteConta", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=5)]
        public gerenteConta[] gerenteConta
        {
            get
            {
                return this.gerenteContaField;
            }
            set
            {
                this.gerenteContaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public long horajAtualizacao
        {
            get
            {
                return this.horajAtualizacaoField;
            }
            set
            {
                this.horajAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horajAtualizacaoSpecified
        {
            get
            {
                return this.horajAtualizacaoFieldSpecified;
            }
            set
            {
                this.horajAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string inscricaoEstadual
        {
            get
            {
                return this.inscricaoEstadualField;
            }
            set
            {
                this.inscricaoEstadualField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string statusCodigo
        {
            get
            {
                return this.statusCodigoField;
            }
            set
            {
                this.statusCodigoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class gerenteConta
    {
        
        private clienteERP[] clientesVisiveisField;
        
        private System.DateTime dataAtualizacaoField;
        
        private bool dataAtualizacaoFieldSpecified;
        
        private System.DateTime dataInclusaoField;
        
        private bool dataInclusaoFieldSpecified;
        
        private System.DateTime dataSenhaField;
        
        private bool dataSenhaFieldSpecified;
        
        private string loginField;
        
        private string matriculaField;
        
        private string senhaField;
        
        private statusGerente statusField;
        
        private bool statusFieldSpecified;
        
        private tipoGerente tipoGerenteField;
        
        private bool tipoGerenteFieldSpecified;
        
        private usuarioInstalacao[] usuariosInstalacaoField;
        
        private string validadeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("clientesVisiveis", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public clienteERP[] clientesVisiveis
        {
            get
            {
                return this.clientesVisiveisField;
            }
            set
            {
                this.clientesVisiveisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public System.DateTime dataAtualizacao
        {
            get
            {
                return this.dataAtualizacaoField;
            }
            set
            {
                this.dataAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataAtualizacaoSpecified
        {
            get
            {
                return this.dataAtualizacaoFieldSpecified;
            }
            set
            {
                this.dataAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime dataInclusao
        {
            get
            {
                return this.dataInclusaoField;
            }
            set
            {
                this.dataInclusaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataInclusaoSpecified
        {
            get
            {
                return this.dataInclusaoFieldSpecified;
            }
            set
            {
                this.dataInclusaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public System.DateTime dataSenha
        {
            get
            {
                return this.dataSenhaField;
            }
            set
            {
                this.dataSenhaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataSenhaSpecified
        {
            get
            {
                return this.dataSenhaFieldSpecified;
            }
            set
            {
                this.dataSenhaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string login
        {
            get
            {
                return this.loginField;
            }
            set
            {
                this.loginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string matricula
        {
            get
            {
                return this.matriculaField;
            }
            set
            {
                this.matriculaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string senha
        {
            get
            {
                return this.senhaField;
            }
            set
            {
                this.senhaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public statusGerente status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public tipoGerente tipoGerente
        {
            get
            {
                return this.tipoGerenteField;
            }
            set
            {
                this.tipoGerenteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipoGerenteSpecified
        {
            get
            {
                return this.tipoGerenteFieldSpecified;
            }
            set
            {
                this.tipoGerenteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usuariosInstalacao", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=9)]
        public usuarioInstalacao[] usuariosInstalacao
        {
            get
            {
                return this.usuariosInstalacaoField;
            }
            set
            {
                this.usuariosInstalacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string validade
        {
            get
            {
                return this.validadeField;
            }
            set
            {
                this.validadeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public enum statusGerente
    {
        
        /// <remarks/>
        Ativo,
        
        /// <remarks/>
        Inativo,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public enum tipoGerente
    {
        
        /// <remarks/>
        GerenteConta,
        
        /// <remarks/>
        GerenteContaMaster,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class usuarioInstalacao
    {
        
        private System.DateTime dataAtualizacaoField;
        
        private bool dataAtualizacaoFieldSpecified;
        
        private System.DateTime dataInclusaoField;
        
        private bool dataInclusaoFieldSpecified;
        
        private System.DateTime dataSenhaField;
        
        private bool dataSenhaFieldSpecified;
        
        private gerenteConta gerenteMasterField;
        
        private string hashSenhaField;
        
        private long idField;
        
        private bool idFieldSpecified;
        
        private string loginField;
        
        private string nomeField;
        
        private parametroMaster[] parametrosField;
        
        private string senhaField;
        
        private statusUsuario statusField;
        
        private bool statusFieldSpecified;
        
        private string validadeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public System.DateTime dataAtualizacao
        {
            get
            {
                return this.dataAtualizacaoField;
            }
            set
            {
                this.dataAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataAtualizacaoSpecified
        {
            get
            {
                return this.dataAtualizacaoFieldSpecified;
            }
            set
            {
                this.dataAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public System.DateTime dataInclusao
        {
            get
            {
                return this.dataInclusaoField;
            }
            set
            {
                this.dataInclusaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataInclusaoSpecified
        {
            get
            {
                return this.dataInclusaoFieldSpecified;
            }
            set
            {
                this.dataInclusaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime dataSenha
        {
            get
            {
                return this.dataSenhaField;
            }
            set
            {
                this.dataSenhaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataSenhaSpecified
        {
            get
            {
                return this.dataSenhaFieldSpecified;
            }
            set
            {
                this.dataSenhaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public gerenteConta gerenteMaster
        {
            get
            {
                return this.gerenteMasterField;
            }
            set
            {
                this.gerenteMasterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string hashSenha
        {
            get
            {
                return this.hashSenhaField;
            }
            set
            {
                this.hashSenhaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string login
        {
            get
            {
                return this.loginField;
            }
            set
            {
                this.loginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parametros", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=8)]
        public parametroMaster[] parametros
        {
            get
            {
                return this.parametrosField;
            }
            set
            {
                this.parametrosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string senha
        {
            get
            {
                return this.senhaField;
            }
            set
            {
                this.senhaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public statusUsuario status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string validade
        {
            get
            {
                return this.validadeField;
            }
            set
            {
                this.validadeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class parametroMaster
    {
        
        private long prmCoParametroField;
        
        private string prmTxParametroField;
        
        private string prmTxValorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long prmCoParametro
        {
            get
            {
                return this.prmCoParametroField;
            }
            set
            {
                this.prmCoParametroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string prmTxParametro
        {
            get
            {
                return this.prmTxParametroField;
            }
            set
            {
                this.prmTxParametroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string prmTxValor
        {
            get
            {
                return this.prmTxValorField;
            }
            set
            {
                this.prmTxValorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public enum statusUsuario
    {
        
        /// <remarks/>
        Ativo,
        
        /// <remarks/>
        Inativo,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class contratoERPPK
    {
        
        private long diretoriaField;
        
        private string numeroField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long diretoria
        {
            get
            {
                return this.diretoriaField;
            }
            set
            {
                this.diretoriaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class unidadePostagemERP
    {
        
        private string diretoriaRegionalField;
        
        private enderecoERP enderecoField;
        
        private string idField;
        
        private string nomeField;
        
        private string statusField;
        
        private string tipoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string diretoriaRegional
        {
            get
            {
                return this.diretoriaRegionalField;
            }
            set
            {
                this.diretoriaRegionalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public enderecoERP endereco
        {
            get
            {
                return this.enderecoField;
            }
            set
            {
                this.enderecoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class enderecoERP
    {
        
        private string bairroField;
        
        private string cepField;
        
        private string cidadeField;
        
        private string complemento2Field;
        
        private string endField;
        
        private string ufField;
        
        private unidadePostagemERP[] unidadesPostagemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string bairro
        {
            get
            {
                return this.bairroField;
            }
            set
            {
                this.bairroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string cep
        {
            get
            {
                return this.cepField;
            }
            set
            {
                this.cepField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string cidade
        {
            get
            {
                return this.cidadeField;
            }
            set
            {
                this.cidadeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string complemento2
        {
            get
            {
                return this.complemento2Field;
            }
            set
            {
                this.complemento2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string end
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unidadesPostagem", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=6)]
        public unidadePostagemERP[] unidadesPostagem
        {
            get
            {
                return this.unidadesPostagemField;
            }
            set
            {
                this.unidadesPostagemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class servicoERP
    {
        
        private string codigoField;
        
        private System.DateTime dataAtualizacaoField;
        
        private bool dataAtualizacaoFieldSpecified;
        
        private int datajAtualizacaoField;
        
        private bool datajAtualizacaoFieldSpecified;
        
        private string descricaoField;
        
        private int horajAtualizacaoField;
        
        private bool horajAtualizacaoFieldSpecified;
        
        private long idField;
        
        private servicoSigep servicoSigepField;
        
        private servicoAdicionalERP[] servicosAdicionaisField;
        
        private string tipo1CodigoField;
        
        private string tipo1DescricaoField;
        
        private string tipo2CodigoField;
        
        private string tipo2DescricaoField;
        
        private vigenciaERP vigenciaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public System.DateTime dataAtualizacao
        {
            get
            {
                return this.dataAtualizacaoField;
            }
            set
            {
                this.dataAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataAtualizacaoSpecified
        {
            get
            {
                return this.dataAtualizacaoFieldSpecified;
            }
            set
            {
                this.dataAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int datajAtualizacao
        {
            get
            {
                return this.datajAtualizacaoField;
            }
            set
            {
                this.datajAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datajAtualizacaoSpecified
        {
            get
            {
                return this.datajAtualizacaoFieldSpecified;
            }
            set
            {
                this.datajAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int horajAtualizacao
        {
            get
            {
                return this.horajAtualizacaoField;
            }
            set
            {
                this.horajAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horajAtualizacaoSpecified
        {
            get
            {
                return this.horajAtualizacaoFieldSpecified;
            }
            set
            {
                this.horajAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public servicoSigep servicoSigep
        {
            get
            {
                return this.servicoSigepField;
            }
            set
            {
                this.servicoSigepField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("servicosAdicionais", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=7)]
        public servicoAdicionalERP[] servicosAdicionais
        {
            get
            {
                return this.servicosAdicionaisField;
            }
            set
            {
                this.servicosAdicionaisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string tipo1Codigo
        {
            get
            {
                return this.tipo1CodigoField;
            }
            set
            {
                this.tipo1CodigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string tipo1Descricao
        {
            get
            {
                return this.tipo1DescricaoField;
            }
            set
            {
                this.tipo1DescricaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string tipo2Codigo
        {
            get
            {
                return this.tipo2CodigoField;
            }
            set
            {
                this.tipo2CodigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string tipo2Descricao
        {
            get
            {
                return this.tipo2DescricaoField;
            }
            set
            {
                this.tipo2DescricaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public vigenciaERP vigencia
        {
            get
            {
                return this.vigenciaField;
            }
            set
            {
                this.vigenciaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class servicoSigep
    {
        
        private categoriaServico categoriaServicoField;
        
        private bool categoriaServicoFieldSpecified;
        
        private chancelaMaster chancelaField;
        
        private string descricaoField;
        
        private bool exigeDimensoesField;
        
        private bool exigeDimensoesFieldSpecified;
        
        private bool exigeValorCobrarField;
        
        private bool exigeValorCobrarFieldSpecified;
        
        private long imitmField;
        
        private string pagamentoEntregaField;
        
        private string remessaAgrupadaField;
        
        private simNao restricaoField;
        
        private bool restricaoFieldSpecified;
        
        private long servicoField;
        
        private servicoERP servicoERPField;
        
        private string ssiCoCodigoPostalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public categoriaServico categoriaServico
        {
            get
            {
                return this.categoriaServicoField;
            }
            set
            {
                this.categoriaServicoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool categoriaServicoSpecified
        {
            get
            {
                return this.categoriaServicoFieldSpecified;
            }
            set
            {
                this.categoriaServicoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public chancelaMaster chancela
        {
            get
            {
                return this.chancelaField;
            }
            set
            {
                this.chancelaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public bool exigeDimensoes
        {
            get
            {
                return this.exigeDimensoesField;
            }
            set
            {
                this.exigeDimensoesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exigeDimensoesSpecified
        {
            get
            {
                return this.exigeDimensoesFieldSpecified;
            }
            set
            {
                this.exigeDimensoesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public bool exigeValorCobrar
        {
            get
            {
                return this.exigeValorCobrarField;
            }
            set
            {
                this.exigeValorCobrarField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exigeValorCobrarSpecified
        {
            get
            {
                return this.exigeValorCobrarFieldSpecified;
            }
            set
            {
                this.exigeValorCobrarFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public long imitm
        {
            get
            {
                return this.imitmField;
            }
            set
            {
                this.imitmField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string pagamentoEntrega
        {
            get
            {
                return this.pagamentoEntregaField;
            }
            set
            {
                this.pagamentoEntregaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string remessaAgrupada
        {
            get
            {
                return this.remessaAgrupadaField;
            }
            set
            {
                this.remessaAgrupadaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public simNao restricao
        {
            get
            {
                return this.restricaoField;
            }
            set
            {
                this.restricaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool restricaoSpecified
        {
            get
            {
                return this.restricaoFieldSpecified;
            }
            set
            {
                this.restricaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public long servico
        {
            get
            {
                return this.servicoField;
            }
            set
            {
                this.servicoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public servicoERP servicoERP
        {
            get
            {
                return this.servicoERPField;
            }
            set
            {
                this.servicoERPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string ssiCoCodigoPostal
        {
            get
            {
                return this.ssiCoCodigoPostalField;
            }
            set
            {
                this.ssiCoCodigoPostalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public enum categoriaServico
    {
        
        /// <remarks/>
        SEM_CATEGORIA,
        
        /// <remarks/>
        PAC,
        
        /// <remarks/>
        SEDEX,
        
        /// <remarks/>
        CARTA,
        
        /// <remarks/>
        GRANDES_FORMATOS,
        
        /// <remarks/>
        REVERSO,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class chancelaMaster
    {
        
        private simNao ativoField;
        
        private bool ativoFieldSpecified;
        
        private byte[] chancelaField;
        
        private System.DateTime dataAtualizacaoField;
        
        private bool dataAtualizacaoFieldSpecified;
        
        private string descricaoField;
        
        private long idField;
        
        private bool idFieldSpecified;
        
        private servicoSigep[] servicosSigepField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public simNao ativo
        {
            get
            {
                return this.ativoField;
            }
            set
            {
                this.ativoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ativoSpecified
        {
            get
            {
                return this.ativoFieldSpecified;
            }
            set
            {
                this.ativoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=1)]
        public byte[] chancela
        {
            get
            {
                return this.chancelaField;
            }
            set
            {
                this.chancelaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime dataAtualizacao
        {
            get
            {
                return this.dataAtualizacaoField;
            }
            set
            {
                this.dataAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataAtualizacaoSpecified
        {
            get
            {
                return this.dataAtualizacaoFieldSpecified;
            }
            set
            {
                this.dataAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("servicosSigep", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=5)]
        public servicoSigep[] servicosSigep
        {
            get
            {
                return this.servicosSigepField;
            }
            set
            {
                this.servicosSigepField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public enum simNao
    {
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class servicoAdicionalERP
    {
        
        private string categoriaField;
        
        private string codigoField;
        
        private System.DateTime dataAtualizacaoField;
        
        private bool dataAtualizacaoFieldSpecified;
        
        private int datajAtualizacaoField;
        
        private bool datajAtualizacaoFieldSpecified;
        
        private string descricaoField;
        
        private int horajAtualizacaoField;
        
        private bool horajAtualizacaoFieldSpecified;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private string siglaField;
        
        private valorDeclarado valorDeclaradoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string categoria
        {
            get
            {
                return this.categoriaField;
            }
            set
            {
                this.categoriaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime dataAtualizacao
        {
            get
            {
                return this.dataAtualizacaoField;
            }
            set
            {
                this.dataAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataAtualizacaoSpecified
        {
            get
            {
                return this.dataAtualizacaoFieldSpecified;
            }
            set
            {
                this.dataAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int datajAtualizacao
        {
            get
            {
                return this.datajAtualizacaoField;
            }
            set
            {
                this.datajAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datajAtualizacaoSpecified
        {
            get
            {
                return this.datajAtualizacaoFieldSpecified;
            }
            set
            {
                this.datajAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int horajAtualizacao
        {
            get
            {
                return this.horajAtualizacaoField;
            }
            set
            {
                this.horajAtualizacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horajAtualizacaoSpecified
        {
            get
            {
                return this.horajAtualizacaoFieldSpecified;
            }
            set
            {
                this.horajAtualizacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string sigla
        {
            get
            {
                return this.siglaField;
            }
            set
            {
                this.siglaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public valorDeclarado valorDeclarado
        {
            get
            {
                return this.valorDeclaradoField;
            }
            set
            {
                this.valorDeclaradoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class valorDeclarado
    {
        
        private double maximoField;
        
        private bool maximoFieldSpecified;
        
        private double minimoField;
        
        private bool minimoFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public double maximo
        {
            get
            {
                return this.maximoField;
            }
            set
            {
                this.maximoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximoSpecified
        {
            get
            {
                return this.maximoFieldSpecified;
            }
            set
            {
                this.maximoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double minimo
        {
            get
            {
                return this.minimoField;
            }
            set
            {
                this.minimoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimoSpecified
        {
            get
            {
                return this.minimoFieldSpecified;
            }
            set
            {
                this.minimoFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class vigenciaERP
    {
        
        private System.DateTime dataFinalField;
        
        private bool dataFinalFieldSpecified;
        
        private System.DateTime dataInicialField;
        
        private bool dataInicialFieldSpecified;
        
        private int datajFimField;
        
        private bool datajFimFieldSpecified;
        
        private int datajIniField;
        
        private bool datajIniFieldSpecified;
        
        private long idField;
        
        private bool idFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public System.DateTime dataFinal
        {
            get
            {
                return this.dataFinalField;
            }
            set
            {
                this.dataFinalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataFinalSpecified
        {
            get
            {
                return this.dataFinalFieldSpecified;
            }
            set
            {
                this.dataFinalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public System.DateTime dataInicial
        {
            get
            {
                return this.dataInicialField;
            }
            set
            {
                this.dataInicialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataInicialSpecified
        {
            get
            {
                return this.dataInicialFieldSpecified;
            }
            set
            {
                this.dataInicialFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int datajFim
        {
            get
            {
                return this.datajFimField;
            }
            set
            {
                this.datajFimField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datajFimSpecified
        {
            get
            {
                return this.datajFimFieldSpecified;
            }
            set
            {
                this.datajFimFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int datajIni
        {
            get
            {
                return this.datajIniField;
            }
            set
            {
                this.datajIniField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datajIniSpecified
        {
            get
            {
                return this.datajIniFieldSpecified;
            }
            set
            {
                this.datajIniFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public enum statusPlp
    {
        
        /// <remarks/>
        Aberta,
        
        /// <remarks/>
        Fechada,
        
        /// <remarks/>
        Postada,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public enum statusObjetoPostal
    {
        
        /// <remarks/>
        EmBranco,
        
        /// <remarks/>
        Postado,
        
        /// <remarks/>
        Cancelado,
        
        /// <remarks/>
        Estorno,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="VerificaSeTodosObjetosCancelados", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class VerificaSeTodosObjetosCancelados
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("arg0", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.objetoPostal[] arg0;
        
        public VerificaSeTodosObjetosCancelados()
        {
        }
        
        public VerificaSeTodosObjetosCancelados(ServiceReferenceCorreios.objetoPostal[] arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="VerificaSeTodosObjetosCanceladosResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class VerificaSeTodosObjetosCanceladosResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public VerificaSeTodosObjetosCanceladosResponse()
        {
        }
        
        public VerificaSeTodosObjetosCanceladosResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="cancelarObjeto", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class cancelarObjeto
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idPlp;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numeroEtiqueta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public cancelarObjeto()
        {
        }
        
        public cancelarObjeto(long idPlp, string numeroEtiqueta, string usuario, string senha)
        {
            this.idPlp = idPlp;
            this.numeroEtiqueta = numeroEtiqueta;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="cancelarObjetoResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class cancelarObjetoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public cancelarObjetoResponse()
        {
        }
        
        public cancelarObjetoResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class dimensaoTO
    {
        
        private medidaTO alturaField;
        
        private medidaTO comprimentoField;
        
        private medidaTO diametroField;
        
        private medidaTO larguraField;
        
        private medidaTO pesoField;
        
        private medidaTO somaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public medidaTO altura
        {
            get
            {
                return this.alturaField;
            }
            set
            {
                this.alturaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public medidaTO comprimento
        {
            get
            {
                return this.comprimentoField;
            }
            set
            {
                this.comprimentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public medidaTO diametro
        {
            get
            {
                return this.diametroField;
            }
            set
            {
                this.diametroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public medidaTO largura
        {
            get
            {
                return this.larguraField;
            }
            set
            {
                this.larguraField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public medidaTO peso
        {
            get
            {
                return this.pesoField;
            }
            set
            {
                this.pesoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public medidaTO soma
        {
            get
            {
                return this.somaField;
            }
            set
            {
                this.somaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class medidaTO
    {
        
        private decimal maximoField;
        
        private bool maximoFieldSpecified;
        
        private decimal minimoField;
        
        private bool minimoFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public decimal maximo
        {
            get
            {
                return this.maximoField;
            }
            set
            {
                this.maximoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximoSpecified
        {
            get
            {
                return this.maximoFieldSpecified;
            }
            set
            {
                this.maximoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public decimal minimo
        {
            get
            {
                return this.minimoField;
            }
            set
            {
                this.minimoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimoSpecified
        {
            get
            {
                return this.minimoFieldSpecified;
            }
            set
            {
                this.minimoFieldSpecified = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="pesquisarParametrosPorDescricao", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class pesquisarParametrosPorDescricao
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string prefix;
        
        public pesquisarParametrosPorDescricao()
        {
        }
        
        public pesquisarParametrosPorDescricao(string prefix)
        {
            this.prefix = prefix;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="pesquisarParametrosPorDescricaoResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class pesquisarParametrosPorDescricaoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.dimensaoTO @return;
        
        public pesquisarParametrosPorDescricaoResponse()
        {
        }
        
        public pesquisarParametrosPorDescricaoResponse(ServiceReferenceCorreios.dimensaoTO @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="atualizaPagamentoNaEntrega", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class atualizaPagamentoNaEntrega
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public atualizaPagamentoNaEntrega()
        {
        }
        
        public atualizaPagamentoNaEntrega(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="atualizaPagamentoNaEntregaResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class atualizaPagamentoNaEntregaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public atualizaPagamentoNaEntregaResponse()
        {
        }
        
        public atualizaPagamentoNaEntregaResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obterClienteAtualizacao", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class obterClienteAtualizacao
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cnpjCliente;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public obterClienteAtualizacao()
        {
        }
        
        public obterClienteAtualizacao(string cnpjCliente, string usuario, string senha)
        {
            this.cnpjCliente = cnpjCliente;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obterClienteAtualizacaoResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class obterClienteAtualizacaoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime @return;
        
        public obterClienteAtualizacaoResponse()
        {
        }
        
        public obterClienteAtualizacaoResponse(System.DateTime @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="verificaDisponibilidadeServico", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class verificaDisponibilidadeServico
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int codAdministrativo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numeroServico;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cepOrigem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cepDestino;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public verificaDisponibilidadeServico()
        {
        }
        
        public verificaDisponibilidadeServico(int codAdministrativo, string numeroServico, string cepOrigem, string cepDestino, string usuario, string senha)
        {
            this.codAdministrativo = codAdministrativo;
            this.numeroServico = numeroServico;
            this.cepOrigem = cepOrigem;
            this.cepDestino = cepDestino;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="verificaDisponibilidadeServicoResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class verificaDisponibilidadeServicoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public verificaDisponibilidadeServicoResponse()
        {
        }
        
        public verificaDisponibilidadeServicoResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="fechaPlpVariosServicos", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class fechaPlpVariosServicos
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string xml;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idPlpCliente;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cartaoPostagem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute("listaEtiquetas", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] listaEtiquetas;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public fechaPlpVariosServicos()
        {
        }
        
        public fechaPlpVariosServicos(string xml, long idPlpCliente, string cartaoPostagem, string[] listaEtiquetas, string usuario, string senha)
        {
            this.xml = xml;
            this.idPlpCliente = idPlpCliente;
            this.cartaoPostagem = cartaoPostagem;
            this.listaEtiquetas = listaEtiquetas;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="fechaPlpVariosServicosResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class fechaPlpVariosServicosResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long @return;
        
        public fechaPlpVariosServicosResponse()
        {
        }
        
        public fechaPlpVariosServicosResponse(long @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="geraDigitoVerificadorEtiquetas", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class geraDigitoVerificadorEtiquetas
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("etiquetas", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] etiquetas;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public geraDigitoVerificadorEtiquetas()
        {
        }
        
        public geraDigitoVerificadorEtiquetas(string[] etiquetas, string usuario, string senha)
        {
            this.etiquetas = etiquetas;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="geraDigitoVerificadorEtiquetasResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class geraDigitoVerificadorEtiquetasResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int[] @return;
        
        public geraDigitoVerificadorEtiquetasResponse()
        {
        }
        
        public geraDigitoVerificadorEtiquetasResponse(int[] @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class embalagemLRSMaster
    {
        
        private string codigoField;
        
        private string nomeField;
        
        private string tipoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obterEmbalagemLRS", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class obterEmbalagemLRS
    {
        
        public obterEmbalagemLRS()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obterEmbalagemLRSResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class obterEmbalagemLRSResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.embalagemLRSMaster[] @return;
        
        public obterEmbalagemLRSResponse()
        {
        }
        
        public obterEmbalagemLRSResponse(ServiceReferenceCorreios.embalagemLRSMaster[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validaEtiquetaPLP", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class validaEtiquetaPLP
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numeroEtiqueta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idPlp;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public validaEtiquetaPLP()
        {
        }
        
        public validaEtiquetaPLP(string numeroEtiqueta, long idPlp, string usuario, string senha)
        {
            this.numeroEtiqueta = numeroEtiqueta;
            this.idPlp = idPlp;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validaEtiquetaPLPResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class validaEtiquetaPLPResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public validaEtiquetaPLPResponse()
        {
        }
        
        public validaEtiquetaPLPResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaServicosValorDeclarado", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaServicosValorDeclarado
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public buscaServicosValorDeclarado()
        {
        }
        
        public buscaServicosValorDeclarado(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaServicosValorDeclaradoResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaServicosValorDeclaradoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] @return;
        
        public buscaServicosValorDeclaradoResponse()
        {
        }
        
        public buscaServicosValorDeclaradoResponse(string[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="consultaCEP", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class consultaCEP
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cep;
        
        public consultaCEP()
        {
        }
        
        public consultaCEP(string cep)
        {
            this.cep = cep;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="consultaCEPResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class consultaCEPResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.enderecoERP @return;
        
        public consultaCEPResponse()
        {
        }
        
        public consultaCEPResponse(ServiceReferenceCorreios.enderecoERP @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="integrarUsuarioScol", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class integrarUsuarioScol
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int codAdministrativo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public integrarUsuarioScol()
        {
        }
        
        public integrarUsuarioScol(int codAdministrativo, string usuario, string senha)
        {
            this.codAdministrativo = codAdministrativo;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="integrarUsuarioScolResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class integrarUsuarioScolResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public integrarUsuarioScolResponse()
        {
        }
        
        public integrarUsuarioScolResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="pesquisarDimensoesServico", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class pesquisarDimensoesServico
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codigo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string embalagem;
        
        public pesquisarDimensoesServico()
        {
        }
        
        public pesquisarDimensoesServico(string codigo, string embalagem)
        {
            this.codigo = codigo;
            this.embalagem = embalagem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="pesquisarDimensoesServicoResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class pesquisarDimensoesServicoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.dimensaoTO @return;
        
        public pesquisarDimensoesServicoResponse()
        {
        }
        
        public pesquisarDimensoesServicoResponse(ServiceReferenceCorreios.dimensaoTO @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public enum tipoEmbalagem
    {
        
        /// <remarks/>
        DE,
        
        /// <remarks/>
        PD,
        
        /// <remarks/>
        RL,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="pesquisarEmbalagensPorServico", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class pesquisarEmbalagensPorServico
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codigo;
        
        public pesquisarEmbalagensPorServico()
        {
        }
        
        public pesquisarEmbalagensPorServico(string codigo)
        {
            this.codigo = codigo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="pesquisarEmbalagensPorServicoResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class pesquisarEmbalagensPorServicoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.tipoEmbalagem[] @return;
        
        public pesquisarEmbalagensPorServicoResponse()
        {
        }
        
        public pesquisarEmbalagensPorServicoResponse(ServiceReferenceCorreios.tipoEmbalagem[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="atualizaRemessaAgrupada", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class atualizaRemessaAgrupada
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public atualizaRemessaAgrupada()
        {
        }
        
        public atualizaRemessaAgrupada(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="atualizaRemessaAgrupadaResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class atualizaRemessaAgrupadaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public atualizaRemessaAgrupadaResponse()
        {
        }
        
        public atualizaRemessaAgrupadaResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="solicitaPLP", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class solicitaPLP
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idPlpMaster;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numEtiqueta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public solicitaPLP()
        {
        }
        
        public solicitaPLP(long idPlpMaster, string numEtiqueta, string usuario, string senha)
        {
            this.idPlpMaster = idPlpMaster;
            this.numEtiqueta = numEtiqueta;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="solicitaPLPResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class solicitaPLPResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public solicitaPLPResponse()
        {
        }
        
        public solicitaPLPResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public enum statusCartao
    {
        
        /// <remarks/>
        Desconhecido,
        
        /// <remarks/>
        Normal,
        
        /// <remarks/>
        Suspenso,
        
        /// <remarks/>
        Cancelado,
        
        /// <remarks/>
        Irregular,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusCartaoPostagem", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class getStatusCartaoPostagem
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numeroCartaoPostagem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public getStatusCartaoPostagem()
        {
        }
        
        public getStatusCartaoPostagem(string numeroCartaoPostagem, string usuario, string senha)
        {
            this.numeroCartaoPostagem = numeroCartaoPostagem;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusCartaoPostagemResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class getStatusCartaoPostagemResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.statusCartao @return;
        
        public getStatusCartaoPostagemResponse()
        {
        }
        
        public getStatusCartaoPostagemResponse(ServiceReferenceCorreios.statusCartao @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="verificaModalTransporte", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class verificaModalTransporte
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codigoServico;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cepOrigem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cepDestino;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public verificaModalTransporte()
        {
        }
        
        public verificaModalTransporte(string codigoServico, string cepOrigem, string cepDestino, string usuario, string senha)
        {
            this.codigoServico = codigoServico;
            this.cepOrigem = cepOrigem;
            this.cepDestino = cepDestino;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="verificaModalTransporteResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class verificaModalTransporteResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public verificaModalTransporteResponse()
        {
        }
        
        public verificaModalTransporteResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaDataAtual", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaDataAtual
    {
        
        public buscaDataAtual()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaDataAtualResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaDataAtualResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime @return;
        
        public buscaDataAtualResponse()
        {
        }
        
        public buscaDataAtualResponse(System.DateTime @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class valePostal
    {
        
        private string cidNoCidadeField;
        
        private string ctcCoAadministrativoField;
        
        private long ctcNuContratoField;
        
        private bool ctcNuContratoFieldSpecified;
        
        private long ctcNuContratoEctField;
        
        private bool ctcNuContratoEctFieldSpecified;
        
        private string cvpEdBairroField;
        
        private string cvpEdClienteField;
        
        private string cvpEdComplementoField;
        
        private string cvpEdNumeroField;
        
        private string cvpNoClienteField;
        
        private long cvpNuCepField;
        
        private bool cvpNuCepFieldSpecified;
        
        private string descricaoErroField;
        
        private string estSgEstadoField;
        
        private int monVarTarifaAdicionalField;
        
        private int monVarTarifaServicoField;
        
        private int monVarValorDescontosField;
        
        private int monVarValorImpostoField;
        
        private long prsCoProdutoServicoField;
        
        private bool prsCoProdutoServicoFieldSpecified;
        
        private long pveNuField;
        
        private bool pveNuFieldSpecified;
        
        private long pveOrgNuAgenciaField;
        
        private bool pveOrgNuAgenciaFieldSpecified;
        
        private long pveOrgNuAgenciaDesField;
        
        private bool pveOrgNuAgenciaDesFieldSpecified;
        
        private long pveOrgNuAgenciaOriField;
        
        private bool pveOrgNuAgenciaOriFieldSpecified;
        
        private int retornaCodErroField;
        
        private string sitNoSituacaoField;
        
        private string tlgTxDescricaoField;
        
        private System.DateTime vapDhTransacaoField;
        
        private bool vapDhTransacaoFieldSpecified;
        
        private string vapNuEtiquetaEncomendaField;
        
        private double vapVrCobradoEctField;
        
        private bool vapVrCobradoEctFieldSpecified;
        
        private double vapVrNominalField;
        
        private bool vapVrNominalFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string cidNoCidade
        {
            get
            {
                return this.cidNoCidadeField;
            }
            set
            {
                this.cidNoCidadeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ctcCoAadministrativo
        {
            get
            {
                return this.ctcCoAadministrativoField;
            }
            set
            {
                this.ctcCoAadministrativoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public long ctcNuContrato
        {
            get
            {
                return this.ctcNuContratoField;
            }
            set
            {
                this.ctcNuContratoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ctcNuContratoSpecified
        {
            get
            {
                return this.ctcNuContratoFieldSpecified;
            }
            set
            {
                this.ctcNuContratoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public long ctcNuContratoEct
        {
            get
            {
                return this.ctcNuContratoEctField;
            }
            set
            {
                this.ctcNuContratoEctField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ctcNuContratoEctSpecified
        {
            get
            {
                return this.ctcNuContratoEctFieldSpecified;
            }
            set
            {
                this.ctcNuContratoEctFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string cvpEdBairro
        {
            get
            {
                return this.cvpEdBairroField;
            }
            set
            {
                this.cvpEdBairroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string cvpEdCliente
        {
            get
            {
                return this.cvpEdClienteField;
            }
            set
            {
                this.cvpEdClienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string cvpEdComplemento
        {
            get
            {
                return this.cvpEdComplementoField;
            }
            set
            {
                this.cvpEdComplementoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string cvpEdNumero
        {
            get
            {
                return this.cvpEdNumeroField;
            }
            set
            {
                this.cvpEdNumeroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string cvpNoCliente
        {
            get
            {
                return this.cvpNoClienteField;
            }
            set
            {
                this.cvpNoClienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public long cvpNuCep
        {
            get
            {
                return this.cvpNuCepField;
            }
            set
            {
                this.cvpNuCepField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cvpNuCepSpecified
        {
            get
            {
                return this.cvpNuCepFieldSpecified;
            }
            set
            {
                this.cvpNuCepFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string descricaoErro
        {
            get
            {
                return this.descricaoErroField;
            }
            set
            {
                this.descricaoErroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string estSgEstado
        {
            get
            {
                return this.estSgEstadoField;
            }
            set
            {
                this.estSgEstadoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public int monVarTarifaAdicional
        {
            get
            {
                return this.monVarTarifaAdicionalField;
            }
            set
            {
                this.monVarTarifaAdicionalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public int monVarTarifaServico
        {
            get
            {
                return this.monVarTarifaServicoField;
            }
            set
            {
                this.monVarTarifaServicoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public int monVarValorDescontos
        {
            get
            {
                return this.monVarValorDescontosField;
            }
            set
            {
                this.monVarValorDescontosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public int monVarValorImposto
        {
            get
            {
                return this.monVarValorImpostoField;
            }
            set
            {
                this.monVarValorImpostoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public long prsCoProdutoServico
        {
            get
            {
                return this.prsCoProdutoServicoField;
            }
            set
            {
                this.prsCoProdutoServicoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prsCoProdutoServicoSpecified
        {
            get
            {
                return this.prsCoProdutoServicoFieldSpecified;
            }
            set
            {
                this.prsCoProdutoServicoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public long pveNu
        {
            get
            {
                return this.pveNuField;
            }
            set
            {
                this.pveNuField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pveNuSpecified
        {
            get
            {
                return this.pveNuFieldSpecified;
            }
            set
            {
                this.pveNuFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public long pveOrgNuAgencia
        {
            get
            {
                return this.pveOrgNuAgenciaField;
            }
            set
            {
                this.pveOrgNuAgenciaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pveOrgNuAgenciaSpecified
        {
            get
            {
                return this.pveOrgNuAgenciaFieldSpecified;
            }
            set
            {
                this.pveOrgNuAgenciaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public long pveOrgNuAgenciaDes
        {
            get
            {
                return this.pveOrgNuAgenciaDesField;
            }
            set
            {
                this.pveOrgNuAgenciaDesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pveOrgNuAgenciaDesSpecified
        {
            get
            {
                return this.pveOrgNuAgenciaDesFieldSpecified;
            }
            set
            {
                this.pveOrgNuAgenciaDesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public long pveOrgNuAgenciaOri
        {
            get
            {
                return this.pveOrgNuAgenciaOriField;
            }
            set
            {
                this.pveOrgNuAgenciaOriField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pveOrgNuAgenciaOriSpecified
        {
            get
            {
                return this.pveOrgNuAgenciaOriFieldSpecified;
            }
            set
            {
                this.pveOrgNuAgenciaOriFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public int retornaCodErro
        {
            get
            {
                return this.retornaCodErroField;
            }
            set
            {
                this.retornaCodErroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public string sitNoSituacao
        {
            get
            {
                return this.sitNoSituacaoField;
            }
            set
            {
                this.sitNoSituacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=23)]
        public string tlgTxDescricao
        {
            get
            {
                return this.tlgTxDescricaoField;
            }
            set
            {
                this.tlgTxDescricaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=24)]
        public System.DateTime vapDhTransacao
        {
            get
            {
                return this.vapDhTransacaoField;
            }
            set
            {
                this.vapDhTransacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vapDhTransacaoSpecified
        {
            get
            {
                return this.vapDhTransacaoFieldSpecified;
            }
            set
            {
                this.vapDhTransacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=25)]
        public string vapNuEtiquetaEncomenda
        {
            get
            {
                return this.vapNuEtiquetaEncomendaField;
            }
            set
            {
                this.vapNuEtiquetaEncomendaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=26)]
        public double vapVrCobradoEct
        {
            get
            {
                return this.vapVrCobradoEctField;
            }
            set
            {
                this.vapVrCobradoEctField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vapVrCobradoEctSpecified
        {
            get
            {
                return this.vapVrCobradoEctFieldSpecified;
            }
            set
            {
                this.vapVrCobradoEctFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=27)]
        public double vapVrNominal
        {
            get
            {
                return this.vapVrNominalField;
            }
            set
            {
                this.vapVrNominalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vapVrNominalSpecified
        {
            get
            {
                return this.vapVrNominalFieldSpecified;
            }
            set
            {
                this.vapVrNominalFieldSpecified = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaTarifaVale", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaTarifaVale
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codAdministrativo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codServico;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cepOrigem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cepDestino;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string peso;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int codFormato;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double comprimento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=9)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double altura;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=10)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double largura;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=11)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double valorDeclarado;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=12)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string servicoAdicional;
        
        public buscaTarifaVale()
        {
        }
        
        public buscaTarifaVale(string codAdministrativo, string usuario, string senha, string codServico, string cepOrigem, string cepDestino, string peso, int codFormato, double comprimento, double altura, double largura, double valorDeclarado, string servicoAdicional)
        {
            this.codAdministrativo = codAdministrativo;
            this.usuario = usuario;
            this.senha = senha;
            this.codServico = codServico;
            this.cepOrigem = cepOrigem;
            this.cepDestino = cepDestino;
            this.peso = peso;
            this.codFormato = codFormato;
            this.comprimento = comprimento;
            this.altura = altura;
            this.largura = largura;
            this.valorDeclarado = valorDeclarado;
            this.servicoAdicional = servicoAdicional;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaTarifaValeResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaTarifaValeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.valePostal @return;
        
        public buscaTarifaValeResponse()
        {
        }
        
        public buscaTarifaValeResponse(ServiceReferenceCorreios.valePostal @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class coletaSimultanea : coleta
    {
        
        private string objField;
        
        private string obsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string obj
        {
            get
            {
                return this.objField;
            }
            set
            {
                this.objField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string obs
        {
            get
            {
                return this.obsField;
            }
            set
            {
                this.obsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(coletaReversa))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(coletaSimultanea))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class coleta
    {
        
        private string cklistField;
        
        private string descricaoField;
        
        private string[] documentoField;
        
        private string id_clienteField;
        
        private produto[] produtoField;
        
        private remetente remetenteField;
        
        private string tipoField;
        
        private string valor_declaradoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string cklist
        {
            get
            {
                return this.cklistField;
            }
            set
            {
                this.cklistField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("documento", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=2)]
        public string[] documento
        {
            get
            {
                return this.documentoField;
            }
            set
            {
                this.documentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string id_cliente
        {
            get
            {
                return this.id_clienteField;
            }
            set
            {
                this.id_clienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("produto", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=4)]
        public produto[] produto
        {
            get
            {
                return this.produtoField;
            }
            set
            {
                this.produtoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public remetente remetente
        {
            get
            {
                return this.remetenteField;
            }
            set
            {
                this.remetenteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string valor_declarado
        {
            get
            {
                return this.valor_declaradoField;
            }
            set
            {
                this.valor_declaradoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class produto
    {
        
        private string codigoField;
        
        private string qtdField;
        
        private string tipoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string qtd
        {
            get
            {
                return this.qtdField;
            }
            set
            {
                this.qtdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class remetente : pessoa
    {
        
        private string celularField;
        
        private string ddd_celularField;
        
        private string identificacaoField;
        
        private string smsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string celular
        {
            get
            {
                return this.celularField;
            }
            set
            {
                this.celularField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ddd_celular
        {
            get
            {
                return this.ddd_celularField;
            }
            set
            {
                this.ddd_celularField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string identificacao
        {
            get
            {
                return this.identificacaoField;
            }
            set
            {
                this.identificacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string sms
        {
            get
            {
                return this.smsField;
            }
            set
            {
                this.smsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(remetente))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class pessoa
    {
        
        private string bairroField;
        
        private string cepField;
        
        private string cidadeField;
        
        private string complementoField;
        
        private string dddField;
        
        private string emailField;
        
        private string logradouroField;
        
        private string nomeField;
        
        private string numeroField;
        
        private string referenciaField;
        
        private string telefoneField;
        
        private string ufField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string bairro
        {
            get
            {
                return this.bairroField;
            }
            set
            {
                this.bairroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string cep
        {
            get
            {
                return this.cepField;
            }
            set
            {
                this.cepField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string cidade
        {
            get
            {
                return this.cidadeField;
            }
            set
            {
                this.cidadeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string complemento
        {
            get
            {
                return this.complementoField;
            }
            set
            {
                this.complementoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string ddd
        {
            get
            {
                return this.dddField;
            }
            set
            {
                this.dddField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string logradouro
        {
            get
            {
                return this.logradouroField;
            }
            set
            {
                this.logradouroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string referencia
        {
            get
            {
                return this.referenciaField;
            }
            set
            {
                this.referenciaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string telefone
        {
            get
            {
                return this.telefoneField;
            }
            set
            {
                this.telefoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class coletaReversa : coleta
    {
        
        private string agField;
        
        private int arField;
        
        private bool arFieldSpecified;
        
        private string cartaoField;
        
        private int numeroField;
        
        private bool numeroFieldSpecified;
        
        private objeto[] obj_colField;
        
        private string servico_adicionalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ag
        {
            get
            {
                return this.agField;
            }
            set
            {
                this.agField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int ar
        {
            get
            {
                return this.arField;
            }
            set
            {
                this.arField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool arSpecified
        {
            get
            {
                return this.arFieldSpecified;
            }
            set
            {
                this.arFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string cartao
        {
            get
            {
                return this.cartaoField;
            }
            set
            {
                this.cartaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroSpecified
        {
            get
            {
                return this.numeroFieldSpecified;
            }
            set
            {
                this.numeroFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("obj_col", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=4)]
        public objeto[] obj_col
        {
            get
            {
                return this.obj_colField;
            }
            set
            {
                this.obj_colField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string servico_adicional
        {
            get
            {
                return this.servico_adicionalField;
            }
            set
            {
                this.servico_adicionalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class objeto
    {
        
        private string descField;
        
        private string entregaField;
        
        private string idField;
        
        private string itemField;
        
        private string numField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string desc
        {
            get
            {
                return this.descField;
            }
            set
            {
                this.descField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string entrega
        {
            get
            {
                return this.entregaField;
            }
            set
            {
                this.entregaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string num
        {
            get
            {
                return this.numField;
            }
            set
            {
                this.numField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validarPostagemSimultanea", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class validarPostagemSimultanea
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int codAdministrativo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int codigoServico;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idCartaoPostagem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cepDestinatario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.coletaSimultanea coleta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public validarPostagemSimultanea()
        {
        }
        
        public validarPostagemSimultanea(int codAdministrativo, int codigoServico, string idCartaoPostagem, string cepDestinatario, ServiceReferenceCorreios.coletaSimultanea coleta, string usuario, string senha)
        {
            this.codAdministrativo = codAdministrativo;
            this.codigoServico = codigoServico;
            this.idCartaoPostagem = idCartaoPostagem;
            this.cepDestinatario = cepDestinatario;
            this.coleta = coleta;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validarPostagemSimultaneaResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class validarPostagemSimultaneaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public validarPostagemSimultaneaResponse()
        {
        }
        
        public validarPostagemSimultaneaResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusPLP", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class getStatusPLP
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("arg0", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.objetoPostal[] arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg1;
        
        public getStatusPLP()
        {
        }
        
        public getStatusPLP(ServiceReferenceCorreios.objetoPostal[] arg0, string arg1)
        {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusPLPResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class getStatusPLPResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.statusPlp @return;
        
        public getStatusPLPResponse()
        {
        }
        
        public getStatusPLPResponse(ServiceReferenceCorreios.statusPlp @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class servicoAdicionalTO
    {
        
        private string categoriaField;
        
        private string codigoField;
        
        private string siglaField;
        
        private string tipoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string categoria
        {
            get
            {
                return this.categoriaField;
            }
            set
            {
                this.categoriaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string sigla
        {
            get
            {
                return this.siglaField;
            }
            set
            {
                this.siglaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="pesquisarServicosAdicionais", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class pesquisarServicosAdicionais
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codigo;
        
        public pesquisarServicosAdicionais()
        {
        }
        
        public pesquisarServicosAdicionais(string codigo)
        {
            this.codigo = codigo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="pesquisarServicosAdicionaisResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class pesquisarServicosAdicionaisResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.servicoAdicionalTO[] @return;
        
        public pesquisarServicosAdicionaisResponse()
        {
        }
        
        public pesquisarServicosAdicionaisResponse(ServiceReferenceCorreios.servicoAdicionalTO[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaServicosXServicosAdicionais", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaServicosXServicosAdicionais
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public buscaServicosXServicosAdicionais()
        {
        }
        
        public buscaServicosXServicosAdicionais(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaServicosXServicosAdicionaisResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaServicosXServicosAdicionaisResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] @return;
        
        public buscaServicosXServicosAdicionaisResponse()
        {
        }
        
        public buscaServicosXServicosAdicionaisResponse(string[] @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class retornoCancelamento
    {
        
        private string cod_erroField;
        
        private string codigo_administrativoField;
        
        private string dataField;
        
        private string horaField;
        
        private string msg_erroField;
        
        private objetoSimplificado objeto_postalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string cod_erro
        {
            get
            {
                return this.cod_erroField;
            }
            set
            {
                this.cod_erroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string codigo_administrativo
        {
            get
            {
                return this.codigo_administrativoField;
            }
            set
            {
                this.codigo_administrativoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string hora
        {
            get
            {
                return this.horaField;
            }
            set
            {
                this.horaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string msg_erro
        {
            get
            {
                return this.msg_erroField;
            }
            set
            {
                this.msg_erroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public objetoSimplificado objeto_postal
        {
            get
            {
                return this.objeto_postalField;
            }
            set
            {
                this.objeto_postalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class objetoSimplificado
    {
        
        private string datahora_cancelamentoField;
        
        private int numero_pedidoField;
        
        private bool numero_pedidoFieldSpecified;
        
        private string status_pedidoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string datahora_cancelamento
        {
            get
            {
                return this.datahora_cancelamentoField;
            }
            set
            {
                this.datahora_cancelamentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int numero_pedido
        {
            get
            {
                return this.numero_pedidoField;
            }
            set
            {
                this.numero_pedidoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numero_pedidoSpecified
        {
            get
            {
                return this.numero_pedidoFieldSpecified;
            }
            set
            {
                this.numero_pedidoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string status_pedido
        {
            get
            {
                return this.status_pedidoField;
            }
            set
            {
                this.status_pedidoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="cancelarPedidoScol", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class cancelarPedidoScol
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codAdministrativo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idPostagem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public cancelarPedidoScol()
        {
        }
        
        public cancelarPedidoScol(string codAdministrativo, string idPostagem, string tipo, string usuario, string senha)
        {
            this.codAdministrativo = codAdministrativo;
            this.idPostagem = idPostagem;
            this.tipo = tipo;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="cancelarPedidoScolResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class cancelarPedidoScolResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.retornoCancelamento @return;
        
        public cancelarPedidoScolResponse()
        {
        }
        
        public cancelarPedidoScolResponse(ServiceReferenceCorreios.retornoCancelamento @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public enum tipoBloqueio
    {
        
        /// <remarks/>
        FRAUDE_BLOQUEIO,
        
        /// <remarks/>
        EXTRAVIO_VAREJO_PRE_INDENIZADO,
        
        /// <remarks/>
        EXTRAVIO_VAREJO_POS_INDENIZADO,
        
        /// <remarks/>
        EXTRAVIO_CORPORATIVO,
        
        /// <remarks/>
        INTERNACIONAL_LDI,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public enum acao
    {
        
        /// <remarks/>
        DEVOLVIDO_AO_REMETENTE,
        
        /// <remarks/>
        ENCAMINHADO_PARA_REFUGO,
        
        /// <remarks/>
        REINTEGRADO_E_DEVOLVIDO_AO_REMETENTE,
        
        /// <remarks/>
        DESBLOQUEADO,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="bloquearObjeto", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class bloquearObjeto
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numeroEtiqueta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idPlp;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.tipoBloqueio tipoBloqueio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.acao acao;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public bloquearObjeto()
        {
        }
        
        public bloquearObjeto(string numeroEtiqueta, long idPlp, ServiceReferenceCorreios.tipoBloqueio tipoBloqueio, ServiceReferenceCorreios.acao acao, string usuario, string senha)
        {
            this.numeroEtiqueta = numeroEtiqueta;
            this.idPlp = idPlp;
            this.tipoBloqueio = tipoBloqueio;
            this.acao = acao;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="bloquearObjetoResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class bloquearObjetoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public bloquearObjetoResponse()
        {
        }
        
        public bloquearObjetoResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaContrato", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaContrato
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numero;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long diretoria;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public buscaContrato()
        {
        }
        
        public buscaContrato(string numero, long diretoria, string usuario, string senha)
        {
            this.numero = numero;
            this.diretoria = diretoria;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaContratoResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaContratoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.contratoERP @return;
        
        public buscaContratoResponse()
        {
        }
        
        public buscaContratoResponse(ServiceReferenceCorreios.contratoERP @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="solicitaEtiquetas", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class solicitaEtiquetas
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipoDestinatario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string identificador;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idServico;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int qtdEtiquetas;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public solicitaEtiquetas()
        {
        }
        
        public solicitaEtiquetas(string tipoDestinatario, string identificador, long idServico, int qtdEtiquetas, string usuario, string senha)
        {
            this.tipoDestinatario = tipoDestinatario;
            this.identificador = identificador;
            this.idServico = idServico;
            this.qtdEtiquetas = qtdEtiquetas;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="solicitaEtiquetasResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class solicitaEtiquetasResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public solicitaEtiquetasResponse()
        {
        }
        
        public solicitaEtiquetasResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="solicitaXmlPlp", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class solicitaXmlPlp
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idPlpMaster;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public solicitaXmlPlp()
        {
        }
        
        public solicitaXmlPlp(long idPlpMaster, string usuario, string senha)
        {
            this.idPlpMaster = idPlpMaster;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="solicitaXmlPlpResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class solicitaXmlPlpResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public solicitaXmlPlpResponse()
        {
        }
        
        public solicitaXmlPlpResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validarPostagemReversa", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class validarPostagemReversa
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codAdministrativo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codigoServico;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cepDestinatario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idCartaoPostagem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.coletaReversa coleta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public validarPostagemReversa()
        {
        }
        
        public validarPostagemReversa(string codAdministrativo, string codigoServico, string cepDestinatario, string idCartaoPostagem, ServiceReferenceCorreios.coletaReversa coleta, string usuario, string senha)
        {
            this.codAdministrativo = codAdministrativo;
            this.codigoServico = codigoServico;
            this.cepDestinatario = cepDestinatario;
            this.idCartaoPostagem = idCartaoPostagem;
            this.coleta = coleta;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validarPostagemReversaResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class validarPostagemReversaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public validarPostagemReversaResponse()
        {
        }
        
        public validarPostagemReversaResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaCliente", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaCliente
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idContrato;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idCartaoPostagem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public buscaCliente()
        {
        }
        
        public buscaCliente(string idContrato, string idCartaoPostagem, string usuario, string senha)
        {
            this.idContrato = idContrato;
            this.idCartaoPostagem = idCartaoPostagem;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaClienteResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaClienteResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.clienteERP @return;
        
        public buscaClienteResponse()
        {
        }
        
        public buscaClienteResponse(ServiceReferenceCorreios.clienteERP @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaPagamentoEntrega", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaPagamentoEntrega
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string contrato;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string dataInicio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string dataFim;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string etiqueta;
        
        public buscaPagamentoEntrega()
        {
        }
        
        public buscaPagamentoEntrega(string usuario, string senha, string contrato, string dataInicio, string dataFim, string etiqueta)
        {
            this.usuario = usuario;
            this.senha = senha;
            this.contrato = contrato;
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
            this.etiqueta = etiqueta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaPagamentoEntregaResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaPagamentoEntregaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public buscaPagamentoEntregaResponse()
        {
        }
        
        public buscaPagamentoEntregaResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="solicitarPostagemScol", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class solicitarPostagemScol
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int codAdministrativo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string xml;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public solicitarPostagemScol()
        {
        }
        
        public solicitarPostagemScol(int codAdministrativo, string xml, string usuario, string senha)
        {
            this.codAdministrativo = codAdministrativo;
            this.xml = xml;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="solicitarPostagemScolResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class solicitarPostagemScolResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public solicitarPostagemScolResponse()
        {
        }
        
        public solicitarPostagemScolResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaServicos", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaServicos
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idContrato;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idCartaoPostagem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public buscaServicos()
        {
        }
        
        public buscaServicos(string idContrato, string idCartaoPostagem, string usuario, string senha)
        {
            this.idContrato = idContrato;
            this.idCartaoPostagem = idCartaoPostagem;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaServicosResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaServicosResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.servicoERP[] @return;
        
        public buscaServicosResponse()
        {
        }
        
        public buscaServicosResponse(ServiceReferenceCorreios.servicoERP[] @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public partial class mensagemParametrizadaTO
    {
        
        private string mensagemField;
        
        private tipoMensagem tipoField;
        
        private bool tipoFieldSpecified;
        
        private string tituloField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string mensagem
        {
            get
            {
                return this.mensagemField;
            }
            set
            {
                this.mensagemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public tipoMensagem tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipoSpecified
        {
            get
            {
                return this.tipoFieldSpecified;
            }
            set
            {
                this.tipoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string titulo
        {
            get
            {
                return this.tituloField;
            }
            set
            {
                this.tituloField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public enum tipoMensagem
    {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        S,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obterMensagemParametrizada", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class obterMensagemParametrizada
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public short id;
        
        public obterMensagemParametrizada()
        {
        }
        
        public obterMensagemParametrizada(short id)
        {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obterMensagemParametrizadaResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class obterMensagemParametrizadaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceCorreios.mensagemParametrizadaTO @return;
        
        public obterMensagemParametrizadaResponse()
        {
        }
        
        public obterMensagemParametrizadaResponse(ServiceReferenceCorreios.mensagemParametrizadaTO @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaOpcoes", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaOpcoes
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("listaObjetos", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] listaObjetos;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipoResultado;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string senha;
        
        public buscaOpcoes()
        {
        }
        
        public buscaOpcoes(string[] listaObjetos, string tipoResultado, string usuario, string senha)
        {
            this.listaObjetos = listaObjetos;
            this.tipoResultado = tipoResultado;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscaOpcoesResponse", WrapperNamespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", IsWrapped=true)]
    public partial class buscaOpcoesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cliente.bean.master.sigep.bsb.correios.com.br/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public buscaOpcoesResponse()
        {
        }
        
        public buscaOpcoesResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface AtendeClienteChannel : ServiceReferenceCorreios.AtendeCliente, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class AtendeClienteClient : System.ServiceModel.ClientBase<ServiceReferenceCorreios.AtendeCliente>, ServiceReferenceCorreios.AtendeCliente
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar o ponto de extremidade de serviço.
    /// </summary>
    /// <param name="serviceEndpoint">O ponto de extremidade a ser configurado</param>
    /// <param name="clientCredentials">As credenciais do cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public AtendeClienteClient() : 
                base(AtendeClienteClient.GetDefaultBinding(), AtendeClienteClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.AtendeClientePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AtendeClienteClient(EndpointConfiguration endpointConfiguration) : 
                base(AtendeClienteClient.GetBindingForEndpoint(endpointConfiguration), AtendeClienteClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AtendeClienteClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(AtendeClienteClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AtendeClienteClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(AtendeClienteClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AtendeClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaServicosAdicionaisAtivosResponse> ServiceReferenceCorreios.AtendeCliente.buscaServicosAdicionaisAtivosAsync(ServiceReferenceCorreios.buscaServicosAdicionaisAtivos request)
        {
            return base.Channel.buscaServicosAdicionaisAtivosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaServicosAdicionaisAtivosResponse> buscaServicosAdicionaisAtivosAsync(string usuario, string senha)
        {
            ServiceReferenceCorreios.buscaServicosAdicionaisAtivos inValue = new ServiceReferenceCorreios.buscaServicosAdicionaisAtivos();
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).buscaServicosAdicionaisAtivosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.fechaPlpResponse> ServiceReferenceCorreios.AtendeCliente.fechaPlpAsync(ServiceReferenceCorreios.fechaPlp request)
        {
            return base.Channel.fechaPlpAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.fechaPlpResponse> fechaPlpAsync(string xml, long idPlpCliente, string cartaoPostagem, string faixaEtiquetas, string usuario, string senha)
        {
            ServiceReferenceCorreios.fechaPlp inValue = new ServiceReferenceCorreios.fechaPlp();
            inValue.xml = xml;
            inValue.idPlpCliente = idPlpCliente;
            inValue.cartaoPostagem = cartaoPostagem;
            inValue.faixaEtiquetas = faixaEtiquetas;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).fechaPlpAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.calculaTarifaServicoResponse> ServiceReferenceCorreios.AtendeCliente.calculaTarifaServicoAsync(ServiceReferenceCorreios.calculaTarifaServico request)
        {
            return base.Channel.calculaTarifaServicoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.calculaTarifaServicoResponse> calculaTarifaServicoAsync(string codAdministrativo, string usuario, string senha, string codServico, string cepOrigem, string cepDestino, string peso, int codFormato, double comprimento, double altura, double largura, double diametro, string codMaoPropria, double valorDeclarado, string codAvisoRecebimento)
        {
            ServiceReferenceCorreios.calculaTarifaServico inValue = new ServiceReferenceCorreios.calculaTarifaServico();
            inValue.codAdministrativo = codAdministrativo;
            inValue.usuario = usuario;
            inValue.senha = senha;
            inValue.codServico = codServico;
            inValue.cepOrigem = cepOrigem;
            inValue.cepDestino = cepDestino;
            inValue.peso = peso;
            inValue.codFormato = codFormato;
            inValue.comprimento = comprimento;
            inValue.altura = altura;
            inValue.largura = largura;
            inValue.diametro = diametro;
            inValue.codMaoPropria = codMaoPropria;
            inValue.valorDeclarado = valorDeclarado;
            inValue.codAvisoRecebimento = codAvisoRecebimento;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).calculaTarifaServicoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.validaPlpResponse> ServiceReferenceCorreios.AtendeCliente.validaPlpAsync(ServiceReferenceCorreios.validaPlp request)
        {
            return base.Channel.validaPlpAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.validaPlpResponse> validaPlpAsync(long cliente, string numero, long diretoria, string cartao, string unidadePostagem, long servico, string[] servicosAdicionais, string usuario, string senha)
        {
            ServiceReferenceCorreios.validaPlp inValue = new ServiceReferenceCorreios.validaPlp();
            inValue.cliente = cliente;
            inValue.numero = numero;
            inValue.diretoria = diretoria;
            inValue.cartao = cartao;
            inValue.unidadePostagem = unidadePostagem;
            inValue.servico = servico;
            inValue.servicosAdicionais = servicosAdicionais;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).validaPlpAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.VerificaSeTodosObjetosCanceladosResponse> ServiceReferenceCorreios.AtendeCliente.VerificaSeTodosObjetosCanceladosAsync(ServiceReferenceCorreios.VerificaSeTodosObjetosCancelados request)
        {
            return base.Channel.VerificaSeTodosObjetosCanceladosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.VerificaSeTodosObjetosCanceladosResponse> VerificaSeTodosObjetosCanceladosAsync(ServiceReferenceCorreios.objetoPostal[] arg0)
        {
            ServiceReferenceCorreios.VerificaSeTodosObjetosCancelados inValue = new ServiceReferenceCorreios.VerificaSeTodosObjetosCancelados();
            inValue.arg0 = arg0;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).VerificaSeTodosObjetosCanceladosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.cancelarObjetoResponse> ServiceReferenceCorreios.AtendeCliente.cancelarObjetoAsync(ServiceReferenceCorreios.cancelarObjeto request)
        {
            return base.Channel.cancelarObjetoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.cancelarObjetoResponse> cancelarObjetoAsync(long idPlp, string numeroEtiqueta, string usuario, string senha)
        {
            ServiceReferenceCorreios.cancelarObjeto inValue = new ServiceReferenceCorreios.cancelarObjeto();
            inValue.idPlp = idPlp;
            inValue.numeroEtiqueta = numeroEtiqueta;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).cancelarObjetoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.pesquisarParametrosPorDescricaoResponse> ServiceReferenceCorreios.AtendeCliente.pesquisarParametrosPorDescricaoAsync(ServiceReferenceCorreios.pesquisarParametrosPorDescricao request)
        {
            return base.Channel.pesquisarParametrosPorDescricaoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.pesquisarParametrosPorDescricaoResponse> pesquisarParametrosPorDescricaoAsync(string prefix)
        {
            ServiceReferenceCorreios.pesquisarParametrosPorDescricao inValue = new ServiceReferenceCorreios.pesquisarParametrosPorDescricao();
            inValue.prefix = prefix;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).pesquisarParametrosPorDescricaoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.atualizaPagamentoNaEntregaResponse> ServiceReferenceCorreios.AtendeCliente.atualizaPagamentoNaEntregaAsync(ServiceReferenceCorreios.atualizaPagamentoNaEntrega request)
        {
            return base.Channel.atualizaPagamentoNaEntregaAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.atualizaPagamentoNaEntregaResponse> atualizaPagamentoNaEntregaAsync(string usuario, string senha)
        {
            ServiceReferenceCorreios.atualizaPagamentoNaEntrega inValue = new ServiceReferenceCorreios.atualizaPagamentoNaEntrega();
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).atualizaPagamentoNaEntregaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.obterClienteAtualizacaoResponse> ServiceReferenceCorreios.AtendeCliente.obterClienteAtualizacaoAsync(ServiceReferenceCorreios.obterClienteAtualizacao request)
        {
            return base.Channel.obterClienteAtualizacaoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.obterClienteAtualizacaoResponse> obterClienteAtualizacaoAsync(string cnpjCliente, string usuario, string senha)
        {
            ServiceReferenceCorreios.obterClienteAtualizacao inValue = new ServiceReferenceCorreios.obterClienteAtualizacao();
            inValue.cnpjCliente = cnpjCliente;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).obterClienteAtualizacaoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.verificaDisponibilidadeServicoResponse> ServiceReferenceCorreios.AtendeCliente.verificaDisponibilidadeServicoAsync(ServiceReferenceCorreios.verificaDisponibilidadeServico request)
        {
            return base.Channel.verificaDisponibilidadeServicoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.verificaDisponibilidadeServicoResponse> verificaDisponibilidadeServicoAsync(int codAdministrativo, string numeroServico, string cepOrigem, string cepDestino, string usuario, string senha)
        {
            ServiceReferenceCorreios.verificaDisponibilidadeServico inValue = new ServiceReferenceCorreios.verificaDisponibilidadeServico();
            inValue.codAdministrativo = codAdministrativo;
            inValue.numeroServico = numeroServico;
            inValue.cepOrigem = cepOrigem;
            inValue.cepDestino = cepDestino;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).verificaDisponibilidadeServicoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.fechaPlpVariosServicosResponse> ServiceReferenceCorreios.AtendeCliente.fechaPlpVariosServicosAsync(ServiceReferenceCorreios.fechaPlpVariosServicos request)
        {
            return base.Channel.fechaPlpVariosServicosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.fechaPlpVariosServicosResponse> fechaPlpVariosServicosAsync(string xml, long idPlpCliente, string cartaoPostagem, string[] listaEtiquetas, string usuario, string senha)
        {
            ServiceReferenceCorreios.fechaPlpVariosServicos inValue = new ServiceReferenceCorreios.fechaPlpVariosServicos();
            inValue.xml = xml;
            inValue.idPlpCliente = idPlpCliente;
            inValue.cartaoPostagem = cartaoPostagem;
            inValue.listaEtiquetas = listaEtiquetas;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).fechaPlpVariosServicosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.geraDigitoVerificadorEtiquetasResponse> ServiceReferenceCorreios.AtendeCliente.geraDigitoVerificadorEtiquetasAsync(ServiceReferenceCorreios.geraDigitoVerificadorEtiquetas request)
        {
            return base.Channel.geraDigitoVerificadorEtiquetasAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.geraDigitoVerificadorEtiquetasResponse> geraDigitoVerificadorEtiquetasAsync(string[] etiquetas, string usuario, string senha)
        {
            ServiceReferenceCorreios.geraDigitoVerificadorEtiquetas inValue = new ServiceReferenceCorreios.geraDigitoVerificadorEtiquetas();
            inValue.etiquetas = etiquetas;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).geraDigitoVerificadorEtiquetasAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.obterEmbalagemLRSResponse> ServiceReferenceCorreios.AtendeCliente.obterEmbalagemLRSAsync(ServiceReferenceCorreios.obterEmbalagemLRS request)
        {
            return base.Channel.obterEmbalagemLRSAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.obterEmbalagemLRSResponse> obterEmbalagemLRSAsync()
        {
            ServiceReferenceCorreios.obterEmbalagemLRS inValue = new ServiceReferenceCorreios.obterEmbalagemLRS();
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).obterEmbalagemLRSAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.validaEtiquetaPLPResponse> ServiceReferenceCorreios.AtendeCliente.validaEtiquetaPLPAsync(ServiceReferenceCorreios.validaEtiquetaPLP request)
        {
            return base.Channel.validaEtiquetaPLPAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.validaEtiquetaPLPResponse> validaEtiquetaPLPAsync(string numeroEtiqueta, long idPlp, string usuario, string senha)
        {
            ServiceReferenceCorreios.validaEtiquetaPLP inValue = new ServiceReferenceCorreios.validaEtiquetaPLP();
            inValue.numeroEtiqueta = numeroEtiqueta;
            inValue.idPlp = idPlp;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).validaEtiquetaPLPAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaServicosValorDeclaradoResponse> ServiceReferenceCorreios.AtendeCliente.buscaServicosValorDeclaradoAsync(ServiceReferenceCorreios.buscaServicosValorDeclarado request)
        {
            return base.Channel.buscaServicosValorDeclaradoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaServicosValorDeclaradoResponse> buscaServicosValorDeclaradoAsync(string usuario, string senha)
        {
            ServiceReferenceCorreios.buscaServicosValorDeclarado inValue = new ServiceReferenceCorreios.buscaServicosValorDeclarado();
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).buscaServicosValorDeclaradoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.consultaCEPResponse> ServiceReferenceCorreios.AtendeCliente.consultaCEPAsync(ServiceReferenceCorreios.consultaCEP request)
        {
            return base.Channel.consultaCEPAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.consultaCEPResponse> consultaCEPAsync(string cep)
        {
            ServiceReferenceCorreios.consultaCEP inValue = new ServiceReferenceCorreios.consultaCEP();
            inValue.cep = cep;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).consultaCEPAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.integrarUsuarioScolResponse> ServiceReferenceCorreios.AtendeCliente.integrarUsuarioScolAsync(ServiceReferenceCorreios.integrarUsuarioScol request)
        {
            return base.Channel.integrarUsuarioScolAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.integrarUsuarioScolResponse> integrarUsuarioScolAsync(int codAdministrativo, string usuario, string senha)
        {
            ServiceReferenceCorreios.integrarUsuarioScol inValue = new ServiceReferenceCorreios.integrarUsuarioScol();
            inValue.codAdministrativo = codAdministrativo;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).integrarUsuarioScolAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.pesquisarDimensoesServicoResponse> ServiceReferenceCorreios.AtendeCliente.pesquisarDimensoesServicoAsync(ServiceReferenceCorreios.pesquisarDimensoesServico request)
        {
            return base.Channel.pesquisarDimensoesServicoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.pesquisarDimensoesServicoResponse> pesquisarDimensoesServicoAsync(string codigo, string embalagem)
        {
            ServiceReferenceCorreios.pesquisarDimensoesServico inValue = new ServiceReferenceCorreios.pesquisarDimensoesServico();
            inValue.codigo = codigo;
            inValue.embalagem = embalagem;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).pesquisarDimensoesServicoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.pesquisarEmbalagensPorServicoResponse> ServiceReferenceCorreios.AtendeCliente.pesquisarEmbalagensPorServicoAsync(ServiceReferenceCorreios.pesquisarEmbalagensPorServico request)
        {
            return base.Channel.pesquisarEmbalagensPorServicoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.pesquisarEmbalagensPorServicoResponse> pesquisarEmbalagensPorServicoAsync(string codigo)
        {
            ServiceReferenceCorreios.pesquisarEmbalagensPorServico inValue = new ServiceReferenceCorreios.pesquisarEmbalagensPorServico();
            inValue.codigo = codigo;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).pesquisarEmbalagensPorServicoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.atualizaRemessaAgrupadaResponse> ServiceReferenceCorreios.AtendeCliente.atualizaRemessaAgrupadaAsync(ServiceReferenceCorreios.atualizaRemessaAgrupada request)
        {
            return base.Channel.atualizaRemessaAgrupadaAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.atualizaRemessaAgrupadaResponse> atualizaRemessaAgrupadaAsync(string usuario, string senha)
        {
            ServiceReferenceCorreios.atualizaRemessaAgrupada inValue = new ServiceReferenceCorreios.atualizaRemessaAgrupada();
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).atualizaRemessaAgrupadaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.solicitaPLPResponse> ServiceReferenceCorreios.AtendeCliente.solicitaPLPAsync(ServiceReferenceCorreios.solicitaPLP request)
        {
            return base.Channel.solicitaPLPAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.solicitaPLPResponse> solicitaPLPAsync(long idPlpMaster, string numEtiqueta, string usuario, string senha)
        {
            ServiceReferenceCorreios.solicitaPLP inValue = new ServiceReferenceCorreios.solicitaPLP();
            inValue.idPlpMaster = idPlpMaster;
            inValue.numEtiqueta = numEtiqueta;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).solicitaPLPAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.getStatusCartaoPostagemResponse> ServiceReferenceCorreios.AtendeCliente.getStatusCartaoPostagemAsync(ServiceReferenceCorreios.getStatusCartaoPostagem request)
        {
            return base.Channel.getStatusCartaoPostagemAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.getStatusCartaoPostagemResponse> getStatusCartaoPostagemAsync(string numeroCartaoPostagem, string usuario, string senha)
        {
            ServiceReferenceCorreios.getStatusCartaoPostagem inValue = new ServiceReferenceCorreios.getStatusCartaoPostagem();
            inValue.numeroCartaoPostagem = numeroCartaoPostagem;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).getStatusCartaoPostagemAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.verificaModalTransporteResponse> ServiceReferenceCorreios.AtendeCliente.verificaModalTransporteAsync(ServiceReferenceCorreios.verificaModalTransporte request)
        {
            return base.Channel.verificaModalTransporteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.verificaModalTransporteResponse> verificaModalTransporteAsync(string codigoServico, string cepOrigem, string cepDestino, string usuario, string senha)
        {
            ServiceReferenceCorreios.verificaModalTransporte inValue = new ServiceReferenceCorreios.verificaModalTransporte();
            inValue.codigoServico = codigoServico;
            inValue.cepOrigem = cepOrigem;
            inValue.cepDestino = cepDestino;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).verificaModalTransporteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaDataAtualResponse> ServiceReferenceCorreios.AtendeCliente.buscaDataAtualAsync(ServiceReferenceCorreios.buscaDataAtual request)
        {
            return base.Channel.buscaDataAtualAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaDataAtualResponse> buscaDataAtualAsync()
        {
            ServiceReferenceCorreios.buscaDataAtual inValue = new ServiceReferenceCorreios.buscaDataAtual();
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).buscaDataAtualAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaTarifaValeResponse> ServiceReferenceCorreios.AtendeCliente.buscaTarifaValeAsync(ServiceReferenceCorreios.buscaTarifaVale request)
        {
            return base.Channel.buscaTarifaValeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaTarifaValeResponse> buscaTarifaValeAsync(string codAdministrativo, string usuario, string senha, string codServico, string cepOrigem, string cepDestino, string peso, int codFormato, double comprimento, double altura, double largura, double valorDeclarado, string servicoAdicional)
        {
            ServiceReferenceCorreios.buscaTarifaVale inValue = new ServiceReferenceCorreios.buscaTarifaVale();
            inValue.codAdministrativo = codAdministrativo;
            inValue.usuario = usuario;
            inValue.senha = senha;
            inValue.codServico = codServico;
            inValue.cepOrigem = cepOrigem;
            inValue.cepDestino = cepDestino;
            inValue.peso = peso;
            inValue.codFormato = codFormato;
            inValue.comprimento = comprimento;
            inValue.altura = altura;
            inValue.largura = largura;
            inValue.valorDeclarado = valorDeclarado;
            inValue.servicoAdicional = servicoAdicional;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).buscaTarifaValeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.validarPostagemSimultaneaResponse> ServiceReferenceCorreios.AtendeCliente.validarPostagemSimultaneaAsync(ServiceReferenceCorreios.validarPostagemSimultanea request)
        {
            return base.Channel.validarPostagemSimultaneaAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.validarPostagemSimultaneaResponse> validarPostagemSimultaneaAsync(int codAdministrativo, int codigoServico, string idCartaoPostagem, string cepDestinatario, ServiceReferenceCorreios.coletaSimultanea coleta, string usuario, string senha)
        {
            ServiceReferenceCorreios.validarPostagemSimultanea inValue = new ServiceReferenceCorreios.validarPostagemSimultanea();
            inValue.codAdministrativo = codAdministrativo;
            inValue.codigoServico = codigoServico;
            inValue.idCartaoPostagem = idCartaoPostagem;
            inValue.cepDestinatario = cepDestinatario;
            inValue.coleta = coleta;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).validarPostagemSimultaneaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.getStatusPLPResponse> ServiceReferenceCorreios.AtendeCliente.getStatusPLPAsync(ServiceReferenceCorreios.getStatusPLP request)
        {
            return base.Channel.getStatusPLPAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.getStatusPLPResponse> getStatusPLPAsync(ServiceReferenceCorreios.objetoPostal[] arg0, string arg1)
        {
            ServiceReferenceCorreios.getStatusPLP inValue = new ServiceReferenceCorreios.getStatusPLP();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).getStatusPLPAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.pesquisarServicosAdicionaisResponse> ServiceReferenceCorreios.AtendeCliente.pesquisarServicosAdicionaisAsync(ServiceReferenceCorreios.pesquisarServicosAdicionais request)
        {
            return base.Channel.pesquisarServicosAdicionaisAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.pesquisarServicosAdicionaisResponse> pesquisarServicosAdicionaisAsync(string codigo)
        {
            ServiceReferenceCorreios.pesquisarServicosAdicionais inValue = new ServiceReferenceCorreios.pesquisarServicosAdicionais();
            inValue.codigo = codigo;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).pesquisarServicosAdicionaisAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaServicosXServicosAdicionaisResponse> ServiceReferenceCorreios.AtendeCliente.buscaServicosXServicosAdicionaisAsync(ServiceReferenceCorreios.buscaServicosXServicosAdicionais request)
        {
            return base.Channel.buscaServicosXServicosAdicionaisAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaServicosXServicosAdicionaisResponse> buscaServicosXServicosAdicionaisAsync(string usuario, string senha)
        {
            ServiceReferenceCorreios.buscaServicosXServicosAdicionais inValue = new ServiceReferenceCorreios.buscaServicosXServicosAdicionais();
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).buscaServicosXServicosAdicionaisAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.cancelarPedidoScolResponse> ServiceReferenceCorreios.AtendeCliente.cancelarPedidoScolAsync(ServiceReferenceCorreios.cancelarPedidoScol request)
        {
            return base.Channel.cancelarPedidoScolAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.cancelarPedidoScolResponse> cancelarPedidoScolAsync(string codAdministrativo, string idPostagem, string tipo, string usuario, string senha)
        {
            ServiceReferenceCorreios.cancelarPedidoScol inValue = new ServiceReferenceCorreios.cancelarPedidoScol();
            inValue.codAdministrativo = codAdministrativo;
            inValue.idPostagem = idPostagem;
            inValue.tipo = tipo;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).cancelarPedidoScolAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.bloquearObjetoResponse> ServiceReferenceCorreios.AtendeCliente.bloquearObjetoAsync(ServiceReferenceCorreios.bloquearObjeto request)
        {
            return base.Channel.bloquearObjetoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.bloquearObjetoResponse> bloquearObjetoAsync(string numeroEtiqueta, long idPlp, ServiceReferenceCorreios.tipoBloqueio tipoBloqueio, ServiceReferenceCorreios.acao acao, string usuario, string senha)
        {
            ServiceReferenceCorreios.bloquearObjeto inValue = new ServiceReferenceCorreios.bloquearObjeto();
            inValue.numeroEtiqueta = numeroEtiqueta;
            inValue.idPlp = idPlp;
            inValue.tipoBloqueio = tipoBloqueio;
            inValue.acao = acao;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).bloquearObjetoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaContratoResponse> ServiceReferenceCorreios.AtendeCliente.buscaContratoAsync(ServiceReferenceCorreios.buscaContrato request)
        {
            return base.Channel.buscaContratoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaContratoResponse> buscaContratoAsync(string numero, long diretoria, string usuario, string senha)
        {
            ServiceReferenceCorreios.buscaContrato inValue = new ServiceReferenceCorreios.buscaContrato();
            inValue.numero = numero;
            inValue.diretoria = diretoria;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).buscaContratoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.solicitaEtiquetasResponse> ServiceReferenceCorreios.AtendeCliente.solicitaEtiquetasAsync(ServiceReferenceCorreios.solicitaEtiquetas request)
        {
            return base.Channel.solicitaEtiquetasAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.solicitaEtiquetasResponse> solicitaEtiquetasAsync(string tipoDestinatario, string identificador, long idServico, int qtdEtiquetas, string usuario, string senha)
        {
            ServiceReferenceCorreios.solicitaEtiquetas inValue = new ServiceReferenceCorreios.solicitaEtiquetas();
            inValue.tipoDestinatario = tipoDestinatario;
            inValue.identificador = identificador;
            inValue.idServico = idServico;
            inValue.qtdEtiquetas = qtdEtiquetas;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).solicitaEtiquetasAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.solicitaXmlPlpResponse> ServiceReferenceCorreios.AtendeCliente.solicitaXmlPlpAsync(ServiceReferenceCorreios.solicitaXmlPlp request)
        {
            return base.Channel.solicitaXmlPlpAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.solicitaXmlPlpResponse> solicitaXmlPlpAsync(long idPlpMaster, string usuario, string senha)
        {
            ServiceReferenceCorreios.solicitaXmlPlp inValue = new ServiceReferenceCorreios.solicitaXmlPlp();
            inValue.idPlpMaster = idPlpMaster;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).solicitaXmlPlpAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.validarPostagemReversaResponse> ServiceReferenceCorreios.AtendeCliente.validarPostagemReversaAsync(ServiceReferenceCorreios.validarPostagemReversa request)
        {
            return base.Channel.validarPostagemReversaAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.validarPostagemReversaResponse> validarPostagemReversaAsync(string codAdministrativo, string codigoServico, string cepDestinatario, string idCartaoPostagem, ServiceReferenceCorreios.coletaReversa coleta, string usuario, string senha)
        {
            ServiceReferenceCorreios.validarPostagemReversa inValue = new ServiceReferenceCorreios.validarPostagemReversa();
            inValue.codAdministrativo = codAdministrativo;
            inValue.codigoServico = codigoServico;
            inValue.cepDestinatario = cepDestinatario;
            inValue.idCartaoPostagem = idCartaoPostagem;
            inValue.coleta = coleta;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).validarPostagemReversaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaClienteResponse> ServiceReferenceCorreios.AtendeCliente.buscaClienteAsync(ServiceReferenceCorreios.buscaCliente request)
        {
            return base.Channel.buscaClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaClienteResponse> buscaClienteAsync(string idContrato, string idCartaoPostagem, string usuario, string senha)
        {
            ServiceReferenceCorreios.buscaCliente inValue = new ServiceReferenceCorreios.buscaCliente();
            inValue.idContrato = idContrato;
            inValue.idCartaoPostagem = idCartaoPostagem;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).buscaClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaPagamentoEntregaResponse> ServiceReferenceCorreios.AtendeCliente.buscaPagamentoEntregaAsync(ServiceReferenceCorreios.buscaPagamentoEntrega request)
        {
            return base.Channel.buscaPagamentoEntregaAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaPagamentoEntregaResponse> buscaPagamentoEntregaAsync(string usuario, string senha, string contrato, string dataInicio, string dataFim, string etiqueta)
        {
            ServiceReferenceCorreios.buscaPagamentoEntrega inValue = new ServiceReferenceCorreios.buscaPagamentoEntrega();
            inValue.usuario = usuario;
            inValue.senha = senha;
            inValue.contrato = contrato;
            inValue.dataInicio = dataInicio;
            inValue.dataFim = dataFim;
            inValue.etiqueta = etiqueta;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).buscaPagamentoEntregaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.solicitarPostagemScolResponse> ServiceReferenceCorreios.AtendeCliente.solicitarPostagemScolAsync(ServiceReferenceCorreios.solicitarPostagemScol request)
        {
            return base.Channel.solicitarPostagemScolAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.solicitarPostagemScolResponse> solicitarPostagemScolAsync(int codAdministrativo, string xml, string usuario, string senha)
        {
            ServiceReferenceCorreios.solicitarPostagemScol inValue = new ServiceReferenceCorreios.solicitarPostagemScol();
            inValue.codAdministrativo = codAdministrativo;
            inValue.xml = xml;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).solicitarPostagemScolAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaServicosResponse> ServiceReferenceCorreios.AtendeCliente.buscaServicosAsync(ServiceReferenceCorreios.buscaServicos request)
        {
            return base.Channel.buscaServicosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaServicosResponse> buscaServicosAsync(string idContrato, string idCartaoPostagem, string usuario, string senha)
        {
            ServiceReferenceCorreios.buscaServicos inValue = new ServiceReferenceCorreios.buscaServicos();
            inValue.idContrato = idContrato;
            inValue.idCartaoPostagem = idCartaoPostagem;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).buscaServicosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.obterMensagemParametrizadaResponse> ServiceReferenceCorreios.AtendeCliente.obterMensagemParametrizadaAsync(ServiceReferenceCorreios.obterMensagemParametrizada request)
        {
            return base.Channel.obterMensagemParametrizadaAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.obterMensagemParametrizadaResponse> obterMensagemParametrizadaAsync(short id)
        {
            ServiceReferenceCorreios.obterMensagemParametrizada inValue = new ServiceReferenceCorreios.obterMensagemParametrizada();
            inValue.id = id;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).obterMensagemParametrizadaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaOpcoesResponse> ServiceReferenceCorreios.AtendeCliente.buscaOpcoesAsync(ServiceReferenceCorreios.buscaOpcoes request)
        {
            return base.Channel.buscaOpcoesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCorreios.buscaOpcoesResponse> buscaOpcoesAsync(string[] listaObjetos, string tipoResultado, string usuario, string senha)
        {
            ServiceReferenceCorreios.buscaOpcoes inValue = new ServiceReferenceCorreios.buscaOpcoes();
            inValue.listaObjetos = listaObjetos;
            inValue.tipoResultado = tipoResultado;
            inValue.usuario = usuario;
            inValue.senha = senha;
            return ((ServiceReferenceCorreios.AtendeCliente)(this)).buscaOpcoesAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.AtendeClientePort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.AtendeClientePort))
            {
                return new System.ServiceModel.EndpointAddress("https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente");
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return AtendeClienteClient.GetBindingForEndpoint(EndpointConfiguration.AtendeClientePort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return AtendeClienteClient.GetEndpointAddress(EndpointConfiguration.AtendeClientePort);
        }
        
        public enum EndpointConfiguration
        {
            
            AtendeClientePort,
        }
    }
}
