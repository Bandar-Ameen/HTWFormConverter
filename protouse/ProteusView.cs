using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winToWeb.protouse
{
   public interface ProteusView
    {
        Manager getViewManager();

        /**
         * @param manager Sets a View Manager on this View.
         */
        void setViewManager(Manager manager);

        /**
         * @return The interface as an Android native View.
         */
    
        Control getAsView();


    }

    public interface Manager
    {

        /**
         * Update the {@link View} with new data.
         *
         * @param data New data for the view
         */
        void update( object data);

        /**
         * Look for a child view with the given id.  If this view has the given
         * id, return this view. Similar to {@link View#findViewById(int)}. Since
         * Proteus is a runtime inflater, layouts use String ids instead of int and it
         * generates unique int ids using the {@link IdGenerator}.
         *
         * @param id The  string id to search for.
         * @return The view that has the given id in the hierarchy or null
         */
       
        Control findViewById( String id);

        /**
         * @return The Proteus Context associated with this Manager.
         */
      

   

        /**
         * Returns this proteus view's extras.
         *
         * @return the Object stored in this view as a extra, or {@code null} if not set
         * @see #setExtras(Object)
         */
      
        object getExtras();

        /**
         * Sets the extra associated with this view. A extra can be used to mark a view in its hierarchy
         * and does not have to be unique within the hierarchy. Extras can also be used to store data
         * within a proteus view without resorting to another data structure.
         * It is similar to {@link View#setTag(Object)}
         *
         * @param extras The object to set as the extra.
         * @see #setExtras(Object)
         */
        void setExtras( object extras);

    }
}
