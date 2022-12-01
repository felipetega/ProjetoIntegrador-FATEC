var qtdProduto1 = 1
var qtdProduto2 = 1
var precoHotdog = 10
var precoXtudo = 25

function produtosIniciais() {
  total = document.getElementById('total')
  hotdog = document.getElementById('hotdog')
  xtudo=document.getElementById("xtudo")

  precoTotal = qtdProduto1 * precoHotdog + qtdProduto2 * precoXtudo
  total.innerText = `Total: R$${precoTotal},00`
  hotdog.innerText = `HotDog  ||  R$${precoHotdog},00`
  xtudo.innerText = `X-tudo  ||  R$${precoXtudo},00`
}


function cpfEcnpj() {
  var cpf = document.getElementById('cpf')
  var cnpj = document.getElementById('cnpj')
  var inputCPF = document.getElementById('inputCPF')
  var inputCNPJ = document.getElementById('inputCNPJ')

  check = document.querySelector('input[name="documento"]:checked').value
  console.log(check)

  if (check == 'CPF') {
    cpf.style.display = 'block'
    cnpj.style.display = 'none'
    inputCPF.required = true
    inputCNPJ.required = false
  } else {
    cpf.style.display = 'none'
    cnpj.style.display = 'block'
    inputCPF.required = false
    inputCNPJ.required = true
  }
}

function endereco() {
  var endereco = document.getElementById('endereco')
  var rua = document.getElementById('rua')
  var estado = document.getElementById('estado')
  var cidade = document.getElementById('cidade')
  var numero = document.getElementById('numero')
  var cep = document.getElementById('cep')

  check = document.querySelector('input[name="tipoAtendimento"]:checked').value
  console.log(check)

  if (check == 'entrega') {
    endereco.style.display = 'block'
    rua.required = true
    estado.required = true
    cidade.required = true
    numero.required = true
    cep.required = true
  } else {
    endereco.style.display = 'none'
    rua.required = false
    estado.required = false
    cidade.required = false
    numero.required = false
    cep.required = false
  }
}

function formaDePagamento() {
  var cartao = document.getElementById('campoCartao')
  var nomeCartao = document.getElementById('nomeCartao')
  var numeroCartao = document.getElementById('numeroCartao')
  var numeroSeguranca = document.getElementById('numeroSeguranca')

  check = document.querySelector('input[name="formaPagamento"]:checked').value
  console.log(check)

  if (check == 'cartao') {
    cartao.style.display = 'block'
    nomeCartao.required = true
    numeroCartao.required = true
    numeroSeguranca.required = true
  } else {
    cartao.style.display = 'none'
    nomeCartao.required = false
    numeroCartao.required = false
    numeroSeguranca.required = false
  }

  var pix = document.getElementById('campoPIX')
  radioPixCPF = document.getElementById('radioPixCPF')
  radioPixFone = document.getElementById('radioPixFone')
  radioPixEmail = document.getElementById('radioPixEmail')
  radioPixKey = document.getElementById('radioPixKey')

  if (check == 'pix') {
    pix.style.display = 'block'
    radioPixCPF.required = true
    radioPixFone.required = true
    radioPixEmail.required = true
    radioPixKey.required = true
  } else {
    pix.style.display = 'none'
    radioPixCPF.required = false
    radioPixFone.required = false
    radioPixEmail.required = false
    radioPixKey.required = false
  }
}

function opcoesPIX() {
  opcoesPix = document.getElementById('inputPIX')
  inputPixCPF = document.getElementById('inputPixCPF')
  labelPixCPF = document.getElementById('labelPixCPF')
  inputPixTelefone = document.getElementById('inputPixTelefone')
  labelPixTelefone = document.getElementById('labelPixTelefone')
  inputPixEmail = document.getElementById('inputPixEmail')
  labelPixEmail = document.getElementById('labelPixEmail')
  inputPixKey = document.getElementById('inputPixKey')
  labelPixKey = document.getElementById('labelPixKey')

  checkPIX = document.querySelector('input[name="pix"]:checked').value
  console.log(checkPIX)

  if (checkPIX == 'pixCPF') {
    opcoesPix.style.display = 'block'
    inputPixCPF.style.display = 'block'
    labelPixCPF.style.display = 'block'
    inputPixCPF.required = true
  } else {
    inputPixCPF.style.display = 'none'
    labelPixCPF.style.display = 'none'
    inputPixCPF.required = false
  }

  if (checkPIX == 'pixFone') {
    opcoesPix.style.display = 'block'
    inputPixTelefone.style.display = 'block'
    labelPixTelefone.style.display = 'block'
    inputPixTelefone.required = true
  } else {
    inputPixTelefone.style.display = 'none'
    labelPixTelefone.style.display = 'none'
    inputPixTelefone.required = false
  }

  if (checkPIX == 'pixEmail') {
    opcoesPix.style.display = 'block'
    inputPixEmail.style.display = 'block'
    labelPixEmail.style.display = 'block'
    inputPixEmail = true
  } else {
    inputPixEmail.style.display = 'none'
    labelPixEmail.style.display = 'none'
    inputPixEmail = false
  }

  if (checkPIX == 'pixKey') {
    opcoesPix.style.display = 'block'
    inputPixKey.style.display = 'block'
    labelPixKey.style.display = 'block'
    inputPixKey.required = true
  } else {
    inputPixKey.style.display = 'none'
    labelPixKey.style.display = 'none'
    inputPixKey.required = false
  }
}

function sucesso() {
  var sucesso = document.getElementById('sucesso')
  sucesso.style.display = 'block'
  window.alert('Sucesso!')
}

function carrinho(id) {
  plus1 = document.getElementById('plus1')
  minus1 = document.getElementById('minus1')
  produto1 = document.getElementById('qtdProduto1')

  plus2 = document.getElementById('plus2')
  minus2 = document.getElementById('minus2')
  produto2 = document.getElementById('qtdProduto2')

  if (id == 'plus1' && qtdProduto1 < 10) {
    qtdProduto1 += 1
    produto1.innerText = `Quantidade: ${qtdProduto1}`
  } else if (id == 'minus1' && qtdProduto1 > 1) {
    qtdProduto1 -= 1
    produto1.innerText = `Quantidade: ${qtdProduto1}`
  }
  if (id == 'plus2' && qtdProduto2 < 10) {
    qtdProduto2 += 1
    produto2.innerText = `Quantidade: ${qtdProduto2}`
  } else if (id == 'minus2' && qtdProduto2 > 1) {
    qtdProduto2 -= 1
    produto2.innerText = `Quantidade: ${qtdProduto2}`
  }
  function total() {
    total = document.getElementById('total')
    precoTotal = qtdProduto1 * precoHotdog + qtdProduto2 * precoXtudo
    total.innerText = `Total: R$${precoTotal},00`
  }
  total()
}
