// Infobox for brukere som vil se valgresultat før valget er over 
$('.btnValgresultatUtilgjengelig').on('click', function () {
    bootbox.alert("Valgresultatet er tilgjengelig etter avstemmingsperioden");
});

// Infobox for brukere som vil stemme etter at valget er over 
$('.btnAvstemmingtUtilgjengelig').on('click', function () {
    bootbox.alert("Valget er n&aring; over");
});

// Infobox for brukere som prøver å registrere seg når de allerede er innlogget
$('.btnErRegistrert').on('click', function () {
    bootbox.alert("Du er allerede registrert og innlogget");
});

// Infobox for brukere som prøver å stemme to ganger
$('.btnHarStemt').on('click', function () {
    bootbox.alert("Du har allerede stemt ved dette valget");
});

// Confirmbox for admin som skal slette et valg
$('.btnSlettValg').on('click', function (e) {
    var form = this.parentElement;
    e.preventDefault();
    backdrop: true,
        bootbox.confirm({
            title: 'SLETTE',
            message: 'Dette vil slette valget',
            buttons: {
                confirm: {
                    label: 'OK',
                },
                cancel: {
                    label: 'AVBRYT',
                }
            },
            callback: function (result) {
                if (result) {
                    form.submit();
                }
            }
        });
});

// Confirmbox for bruker som skal stemme
$('.btnStemmer').on('click', function (e) {
    var form = this.parentElement;
    var userName = this.name;
    e.preventDefault();
    backdrop: true,
        bootbox.confirm({
            title: 'STEMME',
            message: 'Du er n&aring; i ferd med &aring; stemme p&aring; "' + userName + '"',
            buttons: {
                confirm: {
                    label: 'OK',
                },
                cancel: {
                    label: 'AVBRYT',
                }
            },
            callback: function (result) {
                if (result) {
                    form.submit();
                }
            }
        });
});

// Confirmbox for admin som skal endre et valg
$('.btnEndreValg').on('click', function (e) {
    var form = this.parentElement;
    e.preventDefault();
    backdrop: true,
        bootbox.confirm({
            title: 'ENDRING',
            message: 'Du er n&aring; i ferd med &aring; gj&oslash;re endringer for dette valget',
            buttons: {
                confirm: {
                    label: 'OK',
                },
                cancel: {
                    label: 'AVBRYT',
                }
            },
            callback: function (result) {
                if (result) {
                    form.submit();
                }
            }
        });
});



// Confirmbox for bruker som skal slette sitt kandidatur
$('.btnSlettKandidatur').on('click', function (e) {
    var form = this.parentElement;
    e.preventDefault();
    backdrop: true,
        bootbox.confirm({
            title: 'SLETTE',
            message: 'Dette vil slette kandidaturet ditt',
            buttons: {
                confirm: {
                    label: 'OK',
                },
                cancel: {
                    label: 'AVBRYT',
                }
            },
            callback: function (result) {
                if (result) {
                    form.submit();
                }
            }
        });
});

// Confirmbox for admin som skal slette en rolle
$('.btnSlettRolle').on('click', function (e) {
    var form = this.parentElement;
    var roleName = this.name;
    e.preventDefault();

    bootbox.confirm({
        title: 'SLETTE',
        message: 'Dette vil slette rollen: "' + roleName + '"',
        backdrop: true,
        buttons: {
            confirm: {
                label: 'OK',
            },
            cancel: {
                label: 'AVBRYT',
            }
        },
        callback: function (result) {
            if (result) {
                form.submit();
            }
        }
    });
});

// Confirmbox for admin som skal slette en bruker
$('.btnSlettBruker').on('click', function (e) {
    var form = this.parentElement;
    var userName = this.name;
    e.preventDefault();

    bootbox.confirm({
        title: 'SLETTE',
        message: 'Dette vil slette brukeren: "' + userName + '"',
        backdrop: true,
        buttons: {
            confirm: {
                label: 'OK',
            },
            cancel: {
                label: 'AVBRYT',
            }
        },
        callback: function (result) {
            if (result) {
                form.submit();
            }
        }
    });
});

// Gir søkefunksjonalitet til Viewene: UserRoles/Index og Admin/Index
// i DesktopView
function brukerRolleTable() {
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById("brukerRolleTableInput");
    filter = input.value.toUpperCase();
    table = document.getElementById("brukerRolleTable");
    tr = table.getElementsByTagName("tr");

    // Looper gjennom alle tabellradene og gjemmer de radene som ikke matcher søkestrengen
    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("td")[0];
        td1 = tr[i].getElementsByTagName("td")[1];
        td2 = tr[i].getElementsByTagName("td")[2];
        td3 = tr[i].getElementsByTagName("td")[3];
        if (td) {
            txtValue = td.textContent || td.innerText;
            txtValue1 = td1.textContent || td1.innerText;
            txtValue2 = td2.textContent || td2.innerText;
            txtValue3 = td3.textContent || td3.innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1
                || txtValue1.toUpperCase().indexOf(filter) > -1
                || txtValue2.toUpperCase().indexOf(filter) > -1
                || txtValue3.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = "";
            } else {
                tr[i].style.display = "none";
            }
        }
    }
}

// Gir søkefunksjonalitet til Viewene: UserRoles/Index og Admin/Index
// i MobileView
function tableMobile() {
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById("tableInput_mobile");
    filter = input.value.toUpperCase();
    table = document.getElementById("table_mobile");
    tr = table.getElementsByTagName("tr");

    // Looper gjennom en tabellrad og gjemmer de listene som ikke matcher søkestrengen
    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("td")[0];
        if (td) {
            txtValue = td.textContent || td.innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = "";
            } else {
                tr[i].style.display = "none";
            }
        }
    }
}