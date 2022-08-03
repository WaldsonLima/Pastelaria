var usuario = (function () {
    var configs = {
        urls: {
            cadastrar: ''
        }
    };

    var init = function ($configs) {
        configs = $configs;
    };

    var cadastrar = function () {
        model = $('#form-cadastrar').serializeObject();

        $.post(configs.urls.cadastrar, model).done(function () {
            window.alert("Usuário cadastrado com sucesso!");
            $('#form-cadastrar')[0].reset();
        }).fail(function () {
            console.log("Deu bom não");
        });
    };

    return {
        init: init,
        cadastrar: cadastrar
    };
})();
