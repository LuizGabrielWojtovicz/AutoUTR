var url = 'https://localhost:7098/'
//login

const entrarColaborador = () =>
{
fetch(url + 'colaborador')
    .then(response => response.json())
    .then((colaborador) => {

        let emailSelecionado = document.getElementById('email');

        for(let x of colaborador) 
        {
            alert("ok")
        }
    })
}
