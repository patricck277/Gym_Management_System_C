using Firma.Helpers;
using Firma.ViewModels;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace Firma.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {

        #region CommandsMenu


        public ICommand ExitCommand
        {
            get
            {
                return new BaseCommand(ExitApplication);
            }
        }

        private void ExitApplication()
        {
            // Kod do zamknięcia aplikacji
            System.Windows.Application.Current.Shutdown();
        }





        public ICommand ClientCommand
        {
            get
            {

                return new BaseCommand(CreateClient);
            }
        }
        public ICommand PassCommand
        {
            get
            {

                return new BaseCommand(CreatePass);
            }
        }
        public ICommand PayCommand
        {
            get
            {

                return new BaseCommand(CreatePay);
            }
        }
        public ICommand TrainersCommand
        {
            get
            {

                return new BaseCommand(CreateTrainers);
            }
        }
        public ICommand ClassesCommand
        {
            get
            {

                return new BaseCommand(CreateClasses);
            }
        }
        public ICommand AttendanceCommand
        {
            get
            {

                return new BaseCommand(CreateAttendance);
            }
        }
        public ICommand BookingCommand
        {
            get
            {

                return new BaseCommand(CreateBooking);
            }
        }
        public ICommand DiscountCommand
        {
            get
            {

                return new BaseCommand(CreateDiscount);
            }
        }
        public ICommand EmployeesCommand
        {
            get
            {

                return new BaseCommand(CreateEmployees);
            }
        }
        public ICommand EquipmentCommand
        {
            get
            {

                return new BaseCommand(CreateEquipment);
            }
        }
        public ICommand FeedbackCommand
        {
            get
            {

                return new BaseCommand(CreateFeedback);
            }
        }
        public ICommand MessageCommand
        {
            get
            {

                return new BaseCommand(CreateMessage);
            }
        }
        public ICommand OrdersCommand
        {
            get
            {

                return new BaseCommand(CreateOrders);
            }
        }
        public ICommand ProductsCommand
        {
            get
            {

                return new BaseCommand(CreateProducts);
            }
        }
        public ICommand SuppliersCommand
        {
            get
            {

                return new BaseCommand(CreateSuppliers);
            }
        }
        public ICommand AddClientCommand
        {
            get
            {

                return new BaseCommand(CreateAddClient);
            }
        }
        public ICommand AddAttendanceCommand
        {
            get
            {

                return new BaseCommand(CreateAddAttendance);
            }
        }
        public ICommand AddBookingCommand
        {
            get
            {

                return new BaseCommand(CreateAddBooking);
            }
        }
        public ICommand AddClassesCommand
        {
            get
            {

                return new BaseCommand(CreateAddClasses);
            }
        }
        public ICommand AddDiscountCommand
        {
            get
            {

                return new BaseCommand(CreateAddDiscount);
            }
        }
        public ICommand AddEmployeesCommand
        {
            get
            {

                return new BaseCommand(CreateAddEmployees);
            }
        }
        public ICommand AddEquipmentCommand
        {
            get
            {

                return new BaseCommand(CreateAddEquipment);
            }
        }
        public ICommand AddFeedbackCommand
        {
            get
            {

                return new BaseCommand(CreateAddFeedback);
            }
        }
        public ICommand AddMessageCommand
        {
            get
            {

                return new BaseCommand(CreateAddMessage);
            }
        }
        public ICommand AddOrdersCommand
        {
            get
            {

                return new BaseCommand(CreateAddOrders);
            }
        }
        public ICommand AddPassCommand
        {
            get
            {

                return new BaseCommand(CreateAddPass);
            }
        }
        public ICommand AddPayCommand
        {
            get
            {

                return new BaseCommand(CreateAddPay);
            }
        }
        public ICommand AddProductsCommand
        {
            get
            {
                return new BaseCommand(CreateAddProducts);
            }
        }
        public ICommand AddSuppliersCommand
        {
            get
            {

                return new BaseCommand(CreateAddSuppliers);
            }
        }
        public ICommand AddTrainersCommand
        {
            get
            {

                return new BaseCommand(CreateAddTrainers);
            }
        }

        public ICommand RaportCommand
        {
            get
            {

                return new BaseCommand(ShowRaportSprzedazy);
            }
        }

        public ICommand WynikCommand
        {
            get
            {

                return new BaseCommand(ShowWynikuSprzedazy);
            }
        }
        public ICommand OcenaCommand
        {
            get
            {

                return new BaseCommand(ShowOcenaSprzedazy);
            }
        }




        #endregion
        //
        //
        #region Commands
        private ReadOnlyCollection<CommandViewModel> _Commands;
        public ReadOnlyCollection<CommandViewModel> Commands
        {
            get
            {
                if (_Commands == null)
                {
                    //
                    List<CommandViewModel> cmds = CreateCommands();
                    //i ...
                    _Commands = new ReadOnlyCollection<CommandViewModel>(cmds);
                }
                return _Commands;
            }
        }


        private List<CommandViewModel> CreateCommands()
        {
            //Messanger; ( Jak ms. zlapie stringa do otwarcia okna to wywola met. open)
            Messenger.Default.Register<string>(this, open);
            //tworze....
            return new List<CommandViewModel>
            {
                //tu decyduje 
                // new CommandViewModel("Client",new BaseCommand(CreateClient)),
               // new CommandViewModel("Pass",new BaseCommand(CreatePass)),
               // new CommandViewModel("Pay",new BaseCommand(CreatePay)),
               // new CommandViewModel("Trainers",new BaseCommand(CreateTrainers)),
               // new CommandViewModel("Classes",new BaseCommand(CreateClasses)),
               // new CommandViewModel("Attendance",new BaseCommand(ShowAllAttendance)),
               // new CommandViewModel("Booking",new BaseCommand(CreateBooking)),
               // new CommandViewModel("Discount",new BaseCommand(CreateDiscount)),
               // new CommandViewModel("Employees",new BaseCommand(CreateEmployees)),
               // new CommandViewModel("Equipment",new BaseCommand(CreateEquipment)),
               // new CommandViewModel("Feedback",new BaseCommand(CreateFeedback)),
               // new CommandViewModel("Message",new BaseCommand(CreateMessage)),
               // new CommandViewModel("Orders",new BaseCommand(CreateOrders)),
               // new CommandViewModel("Products",new BaseCommand(CreateProducts)),
               // new CommandViewModel("Suppliers",new BaseCommand(CreateSuppliers)),
                new CommandViewModel("Add Client",new BaseCommand(CreateAddClient)),
                new CommandViewModel("Add Pass",new BaseCommand(CreateAddPass)),
                new CommandViewModel("Add Pay",new BaseCommand(CreateAddPay)),
                new CommandViewModel("Add Trainers",new BaseCommand(CreateAddTrainers)),
                new CommandViewModel("Add Classes",new BaseCommand(CreateAddClasses)),
                new CommandViewModel("Add Booking",new BaseCommand(CreateAddBooking)),
                new CommandViewModel("Add Attendance",new BaseCommand(CreateAddAttendance)),
                new CommandViewModel("Add Equipment",new BaseCommand(CreateAddEquipment)),
                new CommandViewModel("Add Employees",new BaseCommand(CreateAddEmployees)),
                new CommandViewModel("Add Products",new BaseCommand(CreateAddProducts)),
                new CommandViewModel("Add Orders",new BaseCommand(CreateAddOrders)),
                new CommandViewModel("Add Suppliers",new BaseCommand(CreateAddSuppliers)),
                new CommandViewModel("Add Discount",new BaseCommand(CreateAddDiscount)),
                new CommandViewModel("Add Feedback",new BaseCommand(CreateAddFeedback)),
                new CommandViewModel("Add Message",new BaseCommand(CreateAddMessage)),
                //new CommandViewModel("Sales Report",new BaseCommand(ShowRaportSprzedazy)),
                //new CommandViewModel("Client Report",new BaseCommand(ShowWynikuSprzedazy)),
                //new CommandViewModel("Trainer Report",new BaseCommand(ShowOcenaSprzedazy))
                };
        }

        private void open(string name)
        {
            if (name == "ClientsAdd") CreateAddClient();
            if (name == "PassAdd") CreateAddPass();
            if (name == "PayAdd") CreateAddPay();
            if (name == "TrainersAdd") CreateAddTrainers();
            if (name == "ClassesAdd") CreateAddClasses();
            if (name == "AttendanceAdd") CreateAddAttendance();
            if (name == "BookingAdd") CreateAddBooking();
            if (name == "DiscountAdd") CreateAddDiscount();
            if (name == "EmployeesAdd") CreateAddEmployees();
            if (name == "EquipmentAdd") CreateAddEquipment();
            if (name == "FeedbackAdd") CreateAddFeedback();
            if (name == "MessageAdd") CreateAddMessage();
            if (name == "OrdersAdd") CreateAddOrders();
            if (name == "ProductsAdd") CreateAddProducts();
            if (name == "SuppliersAdd") CreateAddSuppliers();
            //
            if (name == "ClientShow") ShowAllClient();
            if (name == "ClassesShow") ShowAllClasses();


        }
        #endregion
        #region Workspaces
        //
        private ObservableCollection<WorkspaceViewModel> _Workspaces;
        public ObservableCollection<WorkspaceViewModel> Workspaces
        {
            get
            {
                if (_Workspaces == null)
                {
                    _Workspaces = new ObservableCollection<WorkspaceViewModel>();
                    _Workspaces.CollectionChanged += this.onWorkspacesChanged;
                }
                return _Workspaces;
            }
        }
        #endregion


        #region Zakładki
        private void onWorkspacesChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null && e.NewItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.NewItems)
                    workspace.RequestClose += this.onWorkspaceRequestClose;

            if (e.OldItems != null && e.OldItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.OldItems)
                    workspace.RequestClose -= this.onWorkspaceRequestClose;
        }
        private void onWorkspaceRequestClose(object sender, EventArgs e)
        {
            WorkspaceViewModel workspace = sender as WorkspaceViewModel;
            //workspace.Dispos();
            this.Workspaces.Remove(workspace);
        }
        #endregion

        #region Funkcje wywolu.....
        private void CreateClient()
        {
            ClientViewModel workspace = new ClientViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreatePass()
        {
            PassViewModel workspace = new PassViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreatePay()
        {
            PayViewModel workspace = new PayViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateTrainers()
        {
            TrainersViewModel workspace = new TrainersViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateClasses()
        {
            ClassesViewModel workspace = new ClassesViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateAttendance()
        {
            AttendanceViewModel workspace = new AttendanceViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateBooking()
        {
            BookingViewModel workspace = new BookingViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateDiscount()
        {
            DiscountViewModel workspace = new DiscountViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateEmployees()
        {
            EmployeesViewModel workspace = new EmployeesViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateEquipment()
        {
            EquipmentViewModel workspace = new EquipmentViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateFeedback()
        {
            FeedbackViewModel workspace = new FeedbackViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateMessage()
        {
            MessageViewModel workspace = new MessageViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateOrders()
        {
            OrdersViewModel workspace = new OrdersViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateProducts()
        {
            ProductsViewModel workspace = new ProductsViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateSuppliers()
        {
            SuppliersViewModel workspace = new SuppliersViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateAddClient()
        {
            AddClientViewModel workspace = new AddClientViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateAddAttendance()
        {
            AddAttendanceViewModel workspace = new AddAttendanceViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateAddBooking()
        {
            AddBookingViewModel workspace = new AddBookingViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateAddDiscount()
        {
            AddDiscountViewModel workspace = new AddDiscountViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateAddPass()
        {
            AddPassViewModel workspace = new AddPassViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateAddPay()
        {
            AddPayViewModel workspace = new AddPayViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateAddProducts()
        {
            AddProductsViewModel workspace = new AddProductsViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateAddTrainers()
        {
            AddTrainersViewModel workspace = new AddTrainersViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateAddClasses()
        {
            AddClassesViewModel workspace = new AddClassesViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateAddEmployees()
        {
            AddEmployeesViewModel workspace = new AddEmployeesViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateAddEquipment()
        {
            AddEquipmentViewModel workspace = new AddEquipmentViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateAddFeedback()
        {
            AddFeedbackViewModel workspace = new AddFeedbackViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateAddMessage()
        {
            AddMessageViewModel workspace = new AddMessageViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateAddOrders()
        {
            AddOrdersViewModel workspace = new AddOrdersViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void CreateAddSuppliers()
        {
            AddSuppliersViewModel workspace = new AddSuppliersViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        //
        //
        private void SetActiveWorkspace(WorkspaceViewModel workspace)
        {
            Debug.Assert(this.Workspaces.Contains(workspace));
            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.Workspaces);
            if (collectionView != null)
                collectionView.MoveCurrentTo(workspace);
        }
 
        private void ShowAllClient()
        {
            ClientViewModel workspace = Workspaces.FirstOrDefault(vm => vm is ClientViewModel)
                 as ClientViewModel;
            if (workspace == null)
            {
                workspace = new ClientViewModel();
                Workspaces.Add(workspace);
            }
            SetActiveWorkspace(workspace);
        }
        private void ShowAllClasses()
        {
            ClassesViewModel workspace = Workspaces.FirstOrDefault(vm => vm is ClassesViewModel)
                 as ClassesViewModel;
            if (workspace == null)
            {
                workspace = new ClassesViewModel();
                Workspaces.Add(workspace);
            }
            SetActiveWorkspace(workspace);
        }
        private void ShowRaportSprzedazy()
        {
            RaportSprzedazyViewModel workspace = Workspaces.FirstOrDefault(vm => vm is RaportSprzedazyViewModel)
                 as RaportSprzedazyViewModel;
            if (workspace == null)
            {
                workspace = new RaportSprzedazyViewModel();
                Workspaces.Add(workspace);
            }
            SetActiveWorkspace(workspace);
        }
        private void ShowWynikuSprzedazy()
        {
            RaportWynikuViewModel workspace = Workspaces.FirstOrDefault(vm => vm is RaportWynikuViewModel)
                 as RaportWynikuViewModel;
            if (workspace == null)
            {
                workspace = new RaportWynikuViewModel();
                Workspaces.Add(workspace);
            }
            SetActiveWorkspace(workspace);
        }
        private void ShowOcenaSprzedazy()
        {
            RaportOcenaViewModel workspace = Workspaces.FirstOrDefault(vm => vm is RaportOcenaViewModel)
                 as RaportOcenaViewModel;
            if (workspace == null)
            {
                workspace = new RaportOcenaViewModel();
                Workspaces.Add(workspace);
            }
            SetActiveWorkspace(workspace);
        }

    }
}


#endregion


