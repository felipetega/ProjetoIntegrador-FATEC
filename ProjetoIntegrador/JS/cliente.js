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
  radioPixCPF=document.getElementById("radioPixCPF")
  radioPixFone=document.getElementById("radioPixFone")
  radioPixEmail=document.getElementById("radioPixEmail")
  radioPixKey=document.getElementById("radioPixKey")

  if (check == 'pix') {
    pix.style.display = 'block'
    radioPixCPF.required=true
    radioPixFone.required=true
    radioPixEmail.required=true
    radioPixKey.required=true
  } else {
    pix.style.display = 'none'
    radioPixCPF.required=false
    radioPixFone.required=false
    radioPixEmail.required=false
    radioPixKey.required=false
  }
}

function opcoesPIX() {
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
    inputPixCPF.style.display = 'block'
    labelPixCPF.style.display = 'block'
    inputPixCPF.required = true
  } else {
    inputPixCPF.style.display = 'none'
    labelPixCPF.style.display = 'none'
    inputPixCPF.required = false
  }

  if (checkPIX == 'pixFone') {
    inputPixTelefone.style.display = 'block'
    labelPixTelefone.style.display = 'block'
    inputPixTelefone.required = true
  } else {
    inputPixTelefone.style.display = 'none'
    labelPixTelefone.style.display = 'none'
    inputPixTelefone.required = false
  }

  if (checkPIX == 'pixEmail') {
    inputPixEmail.style.display = 'block'
    labelPixEmail.style.display = 'block'
    inputPixEmail = true
  } else {
    inputPixEmail.style.display = 'none'
    labelPixEmail.style.display = 'none'
    inputPixEmail = false
  }

  if (checkPIX == 'pixKey') {
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
}
