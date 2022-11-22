function cpfEcnpj(){
  var cpf = document.getElementById('cpf')
  var cnpj = document.getElementById('cnpj')
  var inputCPF = document.getElementById('inputCPF')
  var inputCNPJ = document.getElementById('inputCNPJ')

  check=document.querySelector('input[name="documento"]:checked').value;
  console.log(check)

  if (check=="CPF"){
    cpf.style.display = 'block'
    cnpj.style.display = 'none'
    inputCPF.required = true
    inputCNPJ.required = false
  }else{
    cpf.style.display = 'none'
    cnpj.style.display = 'block'
    inputCPF.required = false
    inputCNPJ.required = true
  }
}

function endereco(){
  var endereco = document.getElementById('endereco')
  var rua = document.getElementById('rua')
  var estado = document.getElementById('estado')
  var cidade = document.getElementById('cidade')
  var numero = document.getElementById('numero')

  check=document.querySelector('input[name="tipoAtendimento"]:checked').value;
  console.log(check)

  if(check=="entrega"){
    endereco.style.display = 'block'
    rua.required = true
    estado.required = true
    cidade.required = true
    numero.required = true
  }else{
    endereco.style.display = 'none'
    rua.required = false
    estado.required = false
    cidade.required = false
    numero.required = false
  }
}

function mostraPix(){

}

function formaDePagamento(){
  var cartao = document.getElementById('campoCartao')
  var numeroCartao = document.getElementById('numeroCartao')
  var numeroSeguranca = document.getElementById('numeroSeguranca')

  check=document.querySelector('input[name="formaPagamento"]:checked').value;

  if(check=="cartao"){
    cartao.style.display = 'block'
    numeroCartao.required = true
    numeroSeguranca.required = true
  }else{
    cartao.style.display = 'none'
    numeroCartao.required = false
    numeroSeguranca.required = false
  }
}


















function sucesso() {
  var sucesso = document.getElementById('sucesso')
  sucesso.style.display = 'block'
}