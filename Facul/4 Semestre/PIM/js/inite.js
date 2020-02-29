document.addEventListener('DOMContentLoaded', function() {
    var elems = document.querySelectorAll('.collapsible');
    var instances = M.Collapsible.init(elems);
    var elems = document.querySelectorAll('.datepicker');
    var instances = M.Datepicker.init(elems,);
    var elems = document.querySelectorAll('select');
    var instances = M.FormSelect.init(elems,);
    var elems = document.querySelectorAll('.modal');
    var instances = M.Modal.init(elems,);
    var elems = document.querySelectorAll('.sidenav');
    var instances = M.Sidenav.init(elems,);
})

function errobt(){
    alert("Ainda não funcional! :-)")
}
function cadastrook(){
    alert("Cadastro Efetuado com Sucesso!")
};	
