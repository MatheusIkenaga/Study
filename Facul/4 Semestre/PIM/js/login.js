var username = '';
var senha = '';

function pegaDados(){
var username = document.getElementById('loginUser').value;
var senha = document.getElementById('passwordUser').value;

if (username=='usuario' && senha=='senhac'){
    alert('Login efetuado com sucesso!');
    window.close();
    }
    else{
        alert('Usuário ou Senha incorretos, tente novamente!');
    }
};
