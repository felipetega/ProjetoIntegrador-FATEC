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
  endereco.style.display = 'block'
  cnpj.style.display = 'block'
}

function escondeEndereco() {
  var endereco = document.getElementById('endereco')
  endereco.style.display = 'none'
}

function sucesso() {
  var sucesso = document.getElementById('sucesso')
  sucesso.style.display = 'block'
}