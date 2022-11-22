function cpf() {
  var cpf = document.getElementById('cpf')
  var cnpj = document.getElementById('cnpj')
  cpf.style.display = 'block'
  cnpj.style.display = 'none'

  var inputCPF = document.getElementById('inputCPF')
  var inputCNPJ = document.getElementById('inputCNPJ')
  inputCPF.required = true
  inputCNPJ.required = false
}

function cnpj() {
  var cpf = document.getElementById('cpf')
  var cnpj = document.getElementById('cnpj')
  cpf.style.display = 'none'
  cnpj.style.display = 'block'

  var inputCPF = document.getElementById('inputCPF')
  var inputCNPJ = document.getElementById('inputCNPJ')
  inputCPF.required = false
  inputCNPJ.required = true
}

function mostraEndereco() {
  var endereco = document.getElementById('endereco')
  var rua = document.getElementById('rua')
  var estado = document.getElementById('estado')
  var cidade = document.getElementById('cidade')
  var numero = document.getElementById('numero')


  endereco.style.display = 'block'
  rua.required = true
  estado.required = true
  cidade.required = true
  numero.required = true
}

function escondeEndereco() {
  var endereco = document.getElementById('endereco')
  var rua = document.getElementById('rua')
  var estado = document.getElementById('estado')
  var cidade = document.getElementById('cidade')
  var numero = document.getElementById('numero')


  endereco.style.display = 'none'
  rua.required = false
  estado.required = false
  cidade.required = false
  numero.required = false
}

function sucesso() {
  var sucesso = document.getElementById('sucesso')
  sucesso.style.display = 'block'
}

function mostraPix(){

}

function mostraCartao(){
  var cartao = document.getElementById('campoCartao')
  var numeroCartao = document.getElementById('numeroCartao')
  var numeroSeguranca = document.getElementById('numeroSeguranca')


  cartao.style.display = 'block'
  numeroCartao.required = true
  numeroSeguranca.required = true
}

function escondeCartao(){
  var cartao = document.getElementById('campoCartao')
  var numeroCartao = document.getElementById('numeroCartao')
  var numeroSeguranca = document.getElementById('numeroSeguranca')

  
  cartao.style.display = 'none'
  numeroCartao.required = false
  numeroSeguranca.required = false
}