import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-pessoa-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditPessoaComponent implements OnInit {

  @Input() pes: any;
  @Input() action: any;
  @Input() Disabled: boolean=false;

  PessoaId: string = "";
  PessoaNome: string = "";
  PessoaCPF: string = "";
  PessoaIdade: string = "";
  PessoaCidade: any;
  PessoaCidadeId: string = "";
  CidadeList: any;

  constructor(private service: SharedService) { }

  ngOnInit(): void {
    this.PessoaId = this.pes.id;
    if (this.PessoaId != "0") {
      this.service.getPessoa(this.PessoaId).subscribe(data => {
        this.PessoaId = data.info.id;
        this.PessoaNome = data.info.nome;
        this.PessoaIdade = data.info.idade;
        this.PessoaCPF = data.info.cpf;
        this.PessoaCidadeId = data.info.cidade.id;
        this.PessoaCidade = data.info.cidade.nome;
      });
    }

    this.service.getAllCidade().subscribe(data => {
      this.CidadeList = data.info;
    });
  }

  addPessoa() {
    var nPessoa = {
      id: 0,
      nome: this.PessoaNome,
      idade: this.PessoaIdade,
      cpf: this.PessoaCPF,
      cidadeid: this.PessoaCidadeId
    };
    this.service.addPessoa(nPessoa).subscribe(res => {
      
    })
  }
  updatePessoa() {
    var nPessoa = {
      id: this.PessoaId,
      nome: this.PessoaNome,
      idade: this.PessoaIdade,
      cpf: this.PessoaCPF,
      cidadeid: this.PessoaCidadeId
    };
    this.service.updatePessoa(this.PessoaId, nPessoa).subscribe(res => {
      
    })
  }
  deletePessoa() {
    if (confirm("Deseja mesmo deletar?")) {
      this.service.deletePessoa(this.PessoaId).subscribe(data => {

      })
    }
  }
}
