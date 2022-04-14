import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-pessoa-show',
  templateUrl: './show.component.html',
  styleUrls: ['./show.component.css']
})
export class ShowPessoaComponent implements OnInit {

  constructor(private service:SharedService) { }

  PessoaList:any=[];
  ModalTitle:string="";
  pes:any;
  action:any;
  enableFields:boolean=false;
  Disabled:boolean=false;

  ngOnInit(): void {
    this.refreshPessoa();
  }

  refreshPessoa(){
    this.service.getAllPessoa().subscribe( data =>{
      this.PessoaList=data.info;
    });
  }
  
  closeModal(){
    this.enableFields=false;
    this.refreshPessoa();
  }
  addClick(){
    this.pes={
      id:"",
      nome:"",
      idade:"",
      cidade:"",
      uf:""
    };
    this.action="add";
    this.ModalTitle="Adicionando nova pessoa";
    this.enableFields=true;
    this.Disabled=false;
  }

  editClick(item:any){
    this.pes = item;
    this.action="edit";
    this.ModalTitle="Editando pessoa";
    this.enableFields=true;
    this.Disabled=false;
  }
  deleteClick(item:any){
    this.ModalTitle="Deletando pessoa";
    this.action="del";
    this.enableFields=true;
    this.pes = item;
    this.Disabled=true;
  }
}
