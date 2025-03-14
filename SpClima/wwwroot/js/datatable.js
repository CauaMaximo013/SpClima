// Inicialize o DataTables após o DOM estar carregado
document.addEventListener("DOMContentLoaded", () => {
    const tableElement = document.getElementById("table");
  
    if (tableElement) {
      const dataTable = new DataTable(tableElement, {
        pageLength: 25,
        lengthMenu: [5, 10, 25, 50, 100],
        language: {
          url: "../../lib/datatables.json",
        },
        columnDefs: [
          { targets: 0, visible: false },
          { orderable: false, width: "50px", targets: -1 },
          { targets: "_all", className: "dt-head-left dt-body-left" },
        ],
        layout: {
          topStart: {
            buttons: [
              {
                extend: "copy",
                exportOptions: { columns: ":not(.not-export-col)" },
              },
              {
                extend: "csv",
                exportOptions: { columns: ":not(.not-export-col)" },
              },
              {
                extend: "excel",
                exportOptions: { columns: ":not(.not-export-col)" },
              },
              {
                extend: "pdf",
                exportOptions: { columns: ":not(.not-export-col)" },
              },
              {
                extend: "print",
                exportOptions: { columns: ":not(.not-export-col)" },
              },
              "colvis",
            ],
          },
        },
      });
  
      // Evento disparado quando a tabela termina de ser inicializada
      dataTable.on("init", function () {
        tableElement.classList.remove("d-none");
        dataTable.columns.adjust().draw();
      });
    }
  });
  