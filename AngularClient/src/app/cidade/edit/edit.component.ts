import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-cidade-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditCidadeComponent implements OnInit {

  @Input() cid: any;
  @Input() action: any;
  @Input() Disabled: boolean=false;

  CidadeId: string = "";
  CidadeNome: string = "";
  CidadeUf: string = "";
  constructor(private service: SharedService) { }

  ngOnInit(): void {
    this.CidadeId = this.cid.id;
    this.CidadeNome = this.cid.nome;
    this.CidadeUf = this.cid.uf;
    
  }

  addCidade() {
    var nCid = {
      id: this.CidadeId,
      nome: this.CidadeNome,
      uf: this.CidadeUf
    }
    this.service.addCidade(nCid).subscribe(res => {
      
    })
  }
  updateCidade() {
    var nCid = {
      id: this.CidadeId,
      nome: this.CidadeNome,
      uf: this.CidadeUf
    }
    this.service.updateCidade(this.CidadeId, nCid).subscribe(res => {
      
    })
  }
  deleteCidade() {
    if (confirm("Deseja mesmo deletar?")) {
      this.service.deleteCidade(this.CidadeId).subscribe(data => {

      })
    }
  }
}
