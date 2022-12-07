
let check = (e) =>
{
    tecla = (document.all) ? e.keyCode : e.which;

    if (tecla == 8)
    {
        return true;
    }

    patron = /[A-Za-z0-9]/;
    tecla_final = String.fromCharCode(tecla);
    return patron.test(tecla_final);
}

let SoloNumeros = (e) =>
{

    var key;

    if (window.event)
    {
        key = e.keyCode;
    }
    else if (e.which)
    {
        key = e.which;
    }

    if (key < 48 || key > 57)
    {
        return false;
    }

    return true;
}

let SoloLetras = (letra) =>
{

    tecla = (document.all) ? letra.keyCode : letra.which;

    if (tecla == 8 || tecla == 32)
    {
        return true;
    }

    patron = /[A-Za-z]/;
    tecla_final = String.fromCharCode(tecla);
    return patron.test(tecla_final);

}

let SoloLetrasAndNumeros = (letranum) =>
{

    tecla = (document.all) ? letranum.keyCode : letranum.which;

    if (tecla == 8 || tecla == 32)
    {
        return true;
    }

    patron = /[A-Za-z0-9]/;
    tecla_final = String.fromCharCode(tecla);
    return patron.test(tecla_final);

}
