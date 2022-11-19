//Validação simples
window.onload = function validacao() {
  $('#form').validate({
    debug: true,
    rules: {
      nome: {
        required: true,
        minlength: 3
      },
      senha: {
        required: true,
        minlength: 6
      },
      email: {
        required: true,
        minlength: 6
      },
      nomeCompleto: {
        required: true,
        minlength: 6
      },
      cpf: {
        required: true,
        minlength: 11
      },
      cnpj: {
        required: true,
        minlength: 11
      },
      telefone: {
        required: true,
        rangelength: [8, 9]
      },
      nomeEmpresa: {
        required: true,
        minlength: 3
      },
      numeroCartao: {
        required: true,
        rangelength: [13, 16]
      },
      pix: {
        required: true,
        rangelength: [8, 32]
      },
      cupom: {
        required: true,
        minlength: 3
      },
      cidade: {
        required: true,
        minlength: 3
      },
      numeroCasa: {
        required: true,
        minlength: 1
      },
      cep: {
        required: true,
        rangelength: [8, 8]
      },
      estado: {
        required: true
      },
      rua: {
        required: true,
        minlength: 3
      },
      tipoDeAtendimento: {
        required: true,
        maxlength: 1
      },
      formaDePagamento: {
        required: true,
        rangelength: [1, 1]
      },
      bairro: {
        required: true,
        minlength: 3
      },
      cidade: {
        required: true,
        minlength: 3
      },
      nomeCartao: {
        required: true,
        minlength: 3
      },
      numeroSeguranca: {
        required: true,
        rangelength: [3, 4]
      },
      mesExpiraçao: {
        required: true,
        minlength: 1
      },
      anoExpiraçao: {
        required: true,
        minlength: 1
      },
      quantidadeProdutos: {
        required: true,
        step: 1
      },
      entrega: {
        required: true,
        minlength: 1
      }
    }
  })
}

