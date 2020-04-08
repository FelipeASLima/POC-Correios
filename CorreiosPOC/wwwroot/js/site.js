
$(document).ready(function () {
    $(".cep").mask("99999-999");
    Table();   
});

$("#pesquisaCEP").submit(function () {
    event.preventDefault();
    $.ajax({
        url: "v1/GetCEPCorreios",
        type: "GET",
        dataType: 'json',
        data: { cep: $('#inp_busca_cep').val() },
        contentType: 'application/json; charset=utf-8',
        success: function (result) {
            ExibeResultado(result);
            Noty('success', null, 'CEP encontrado!');
        },
        error: function (xhr, exception) {
            Noty('warning', null, 'CEP invalido!');
        }
    });
})

function ExibeResultado(endereco) {
    $('#inp_cep').val(endereco.cep);
    $('#inp_endereco').val(endereco.endereco);
    $('#inp_complemento').val(endereco.complemento);
    $('#inp_bairo').val(endereco.bairro);
    $('#inp_cidade').val(endereco.cidade);
    $('#inp_uf').val(endereco.uf);
}

function serializeFormJSON(form) {
    var o = {};
    var a = $(form).serializeArray();
    $.each(a, function () {
        if (o[this.name]) {
            if (!o[this.name].push) {
                o[this.name] = [o[this.name]];
            }
            o[this.name].push(this.value || '');
        } else {
            o[this.name] = this.value || '';
        }
    });
    return o;
};

$("#salvarEndereco").submit(function () {
    event.preventDefault();
    var formData = serializeFormJSON($("form#salvarEndereco"));
    if (formData.cep) {
        $.ajax({
            url: "v1/AdicionarEndereco",
            type: "POST",
            data: JSON.stringify(formData),
            contentType: 'application/json; charset=utf-8',
            success: function (result) {
                $table.ajax.reload();
                Noty('success', null, 'Endereço salvo com sucesso!');
            },
            error: function (xhr, exception) {
                $table.ajax.reload();
                Noty('warning', null, 'Não foi possivel salvar o endereço.');
            }
        });
    }
})

function editarEndereco(id) {
    $endereco = id;
    let data = $json.filter(function (item) { return item.id === id; });

    $.each(data[0], function (key, value) {
        $('[name=' + key + ']', '#editarEndereco').val(value);
    });

    $('#modalEditarEndereco').modal('show');
};

$("#editarEndereco").submit(function () {
    event.preventDefault();
    var formData = serializeFormJSON($("form#editarEndereco"));
    $.ajax({
        url: "v1/EditarEndereco/" + $endereco,
        type: "PUT",
        data: JSON.stringify(formData),
        contentType: 'application/json; charset=utf-8',
        success: function (result) {
            $table.ajax.reload();
            $('#modalEditarEndereco').modal('hide');
            Noty('success', null, 'Endereço editado com sucesso!');
        },
        error: function (xhr, exception) {
            $table.ajax.reload();
            $('#modalEditarEndereco').modal('hide');
            Noty('warning', null, 'Não foi possivel editar o endereço.');
        }
    });
});

function excluirEndereco(endereco) {
    if (confirm('Deseja realmente excluir o endereço?')) {
        $.ajax({
            url: "v1/RemoverEndereco/" + endereco,
            type: "DELETE",
            contentType: 'application/json; charset=utf-8',
            success: function (result) {
                $table.ajax.reload();
                Noty('success', null, 'Endereço excluido com sucesso!');
            },
            error: function (xhr, exception) {
                $table.ajax.reload();
                Noty('warning', null, 'Não foi possivel excluir o endereço.');
            }
        });
    }
};

function Table() {
    $table = $("#tabelaEndereco2").DataTable({
        oLanguage: {
            sZeroRecords: "Nenhum endereço encontrado"
        },
        ajax: {
            url: "v1/ListaEnderecos",
            type: "GET",
            contentType: 'application/json; charset=utf-8',
            dataSrc: function (json) {
                $json = json;
                return json;
            }
        },
        data: [],
        columns: [
            { title: "CEP", data: "cep" },
            { title: "Endereco", data: "endereco", class: "texto" },
            { title: "Complemento", data: "complemento", class: "texto" },
            { title: "Bairro", data: "bairro", class: "texto" },
            { title: "Cidade", data: "cidade", class: "texto" },
            { title: "UF", data: "uf" },
            { title: "Opções", data: null, width: '5%' }
        ],
        columnDefs: [{
            targets: 6,
            searchable: false,
            orderable: false,
            render: function (data, type, full, meta) {
                return '<a data-toggle="tooltip" title="Editar" onclick="editarEndereco(' + data.id + ')" style="cursor:pointer;">Editar</a>' +
                    '&nbsp' +
                    '<a data-toggle="tooltip" title="Excluir" onclick="excluirEndereco(' + data.id + ')" style="cursor:pointer;color: red;">Excluir</a>';
            }
        }],
        responsive: true

    });
}

function Noty(tipo, msg, titulo) {

    Command: toastr[tipo](msg, titulo)

    toastr.options = {
        "closeButton": true,
        "debug": false,
        "newestOnTop": true,
        "progressBar": true,
        "positionClass": "toast-top-right",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }
}

$(".closeModal").on('click', function () {
    $('#modalEditarEndereco').modal('hide');
})
